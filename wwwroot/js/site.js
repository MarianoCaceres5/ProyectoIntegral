// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var IdCategoria = -1;

function MostrarProductosPorCategoria(idC){

    $.ajax({

        url: '/Home/MostrarProductosPorCategoria',
        data: {IdCategoria: idC},
        type:'POST',
        dataType:'JSON',            
        success:
            function (resp){  
                
                if(IdCategoria == idC){
                    $('.'+idC).hide();  
                }else{
                    $('.'+idC).show();  
                }
                IdCategoria = idC;
                                              
                $('.divProductos').show();
                $('#listaProductos').html(' ');
                resp.forEach(producto => {
                    //$('.listaProductos').append('<div class="carousel-item active"><img alt="' +producto.idProducto + '" class="d-block imgProductoCarousel" src="' + producto.fotoProducto + '"> <div class="carousel-caption d-none d-md-block"><h3 class="text-dark">' + producto.nombreProducto +'</h3></div></div> ')
                    $('#listaProductos').append('<div class="col-sm d-flex mb-3 justify-content-center"><div class="p-3 contenedor card cardd mb-4" style=""> <div class="text-center" id="contenedor" onclick="MostrarProducto('+ producto.idProducto +')"> <img src="'+producto.fotoProducto + '" class="FotoProducto card-img-top p-4 flex-item"> <div class="centerr btn btn-outline-secondary" id="boton">DETALLE</div></div> <div class="card-body mt-3"> <h4 class="card-title mb-1 text-dark" onclick="MostrarProducto('+ producto.idProducto +')">' + producto.nombreProducto +'</h4>  <h5 class="mb-3 text-dark"> $' + producto.precioProducto +'<span style="color:grey"> o en dos cuotas de <span style="color:gold">$' + producto.precioProducto / 2   + '</span></span></h5>  </div></div></div>');
                });        
            

            },
        error:
            function(){
                console.log('error');
            }

    });    
    
}

//

function MostrarProducto(idP){
    $.ajax({

        url: '/Home/ModalProducto',
        data: {IdProducto: idP},
        type:'POST',
        dataType:'JSON',            
        success:
            function (resp){                  
                              
                $('.modal').show();
                $('#FotoProducto').html('<img src="'+resp.fotoProducto + '" width="100%" height="auto" class="">')
                $('#DescripcionProducto').html('<h4 style="color:gray;">'+resp.materialProducto + ' </h4> <h2>'+resp.nombreProducto + ' </h2> <h2>$'+resp.precioProducto + ',00 </h2> <h4 style="margin-top:10px; color:gray;" >En 2 cuotas sin interés de <span style="color:green;">$'+resp.precioProducto / 2 + '</span> </h4> <h6 style="margin-top:20px; color:gray;">'+resp.descripcionProducto + ' </h6> <button onclick="AgregarAlCarrito('+ resp.idProducto +')" class="agregarCarrito btn btn-outline-secondary mt-3">AGREGAR AL CARRITO</button>');                                       
                $('.divProductos').show();

            },
        error:
            function(){
                console.log('error');
            }

    });
}

//

function AgregarAlCarrito(idP){
    
    $.ajax({

        url: '/Home/AgregarAlCarrito',
        data: {IdProducto: idP},
        type:'POST',
        dataType:'JSON',            
        success:
            function (resp){        
                
                console.log("se agrego al carrito");   
                console.log(cantUnidades);
                              
                
            },
        error:
            function(){
                console.log('error');
                
            }

    });
}

//

function BuscarProductos(busqueda){   

    $.ajax({

        url: '/Home/BuscarProductos',
        data: {Busqueda: busqueda},
        type:'POST',
        dataType:'JSON',            
        success:
            function (resp){                 
                

                $('#listaProductos').html('');
                resp.forEach(producto => {
                    $('#listaProductos').append('<div class="col-sm d-flex mb-3 justify-content-center"><div class="p-3 contenedor card cardd mb-4" style=""> <div class="text-center" id="contenedor" onclick="MostrarProducto('+ producto.idProducto +')"> <img src="'+producto.fotoProducto + '" class="FotoProducto card-img-top p-4 flex-item"> <div class="centerr btn btn-outline-secondary" id="boton">DETALLE</div></div> <div class="card-body mt-3"> <h4 class="card-title mb-1 text-dark" onclick="MostrarProducto('+ producto.idProducto +')">' + producto.nombreProducto +'</h4>  <h5 class="mb-3 text-dark"> $' + producto.precioProducto +'<span style="color:grey"> o en dos cuotas de <span style="color:gold">$' + producto.precioProducto / 2   + '</span></span></h5>  </div></div></div>');
                });
                

            },
        error:
            function(){
                console.log('error');
            }

    });

}

//

function FiltrarPorMaterial(material){
    $.ajax({

        url: '/Home/MostrarProductosPorCategoria',
        data: {IdCategoria: IdCategoria},
        type:'POST',
        dataType:'JSON',            
        success:
            function (resp){                       
                                
                $('.divProductos').show();
                $('#listaProductos').html(' ');
                resp.forEach(producto => {
                    
                    if(producto.materialProducto == material){
                        $('#listaProductos').append('<div class="col-sm d-flex mb-3 justify-content-center"><div class="p-3 contenedor card cardd mb-4" style=""> <div class="text-center" id="contenedor" onclick="MostrarProducto('+ producto.idProducto +')"> <img src="'+producto.fotoProducto + '" class="FotoProducto card-img-top p-4 flex-item"> <div class="centerr btn btn-outline-secondary" id="boton">DETALLE</div></div> <div class="card-body mt-3"> <h4 class="card-title mb-1 text-dark" onclick="MostrarProducto('+ producto.idProducto +')">' + producto.nombreProducto +'</h4>  <h5 class="mb-3 text-dark"> $' + producto.precioProducto +'<span style="color:grey"> o en dos cuotas de <span style="color:gold">$' + producto.precioProducto / 2   + '</span></span></h5>  </div></div></div>');
                    }
                    
                });        
            

            },
        error:
            function(){
                console.log('error');
            }

    });
}