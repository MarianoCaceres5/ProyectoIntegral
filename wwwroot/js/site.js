// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function MostrarProductosPorCategoria(idC){
    $.ajax({

        url: '/Home/MostrarProductosPorCategoria',
        data: {IdCategoria: idC},
        type:'POST',
        dataType:'JSON',            
        success:
            function (resp){                       
                                
                $('.divProductos').show();
                $('#listaProductos').html(' ');
                resp.forEach(producto => {
                    //$('.listaProductos').append('<div class="carousel-item active"><img alt="' +producto.idProducto + '" class="d-block imgProductoCarousel" src="' + producto.fotoProducto + '"> <div class="carousel-caption d-none d-md-block"><h3 class="text-dark">' + producto.nombreProducto +'</h3></div></div> ')
                    $('#listaProductos').append('<div class="col-sm d-flex mb-3 justify-content-center"><div class="p-3 contenedor card cardd mb-4" style=""> <div class="text-center" id="contenedor" onclick="MostrarProducto('+ producto.idProducto +')"> <img src="'+producto.fotoProducto + '" class="FotoProducto card-img-top p-4 flex-item"> <div class="centerr btn btn-outline-secondary" id="boton">DETALLE</div></div> <div class="card-body mt-3""> <h4 class="card-title mb-1 text-dark" onclick="MostrarProducto('+ producto.idProducto +')">' + producto.nombreProducto +'</h4> <h5 class="mb-3 text-dark"> $' + producto.precioProducto +'<span style="color:grey"> o en dos cuotas de <span style="color:gold">$' + producto.precioProducto / 2   + '</span></span></h5>  </div></div></div>');
                });                                

            },
        error:
            function(){
                console.log('error');
            }

        });
}


function MostrarProducto(idP){
    $.ajax({

        url: '/Home/ModalProducto',
        data: {IdProducto: idP},
        type:'POST',
        dataType:'JSON',            
        success:
            function (resp){                   
                
                console.log(resp.nombreProducto);  
                $('.modal').show();
                $('#NombreProducto').html(resp.nombreProducto);                                       
                                             

            },
        error:
            function(){
                console.log('error');
            }

        });
}