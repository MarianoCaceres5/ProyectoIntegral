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
                    $('#listaProductos').append('<div class="col-sm d-flex mb-3 justify-content-center"><div class="p-3 contenedor card mb-4 border" style="width: 330px; height:460px; border-radius:5%"> <img src="'+producto.fotoProducto + '" class="containerFotoProducto card-img-top p-4 imagen flex-item" width="90%" height="330px" style="object-fit: cover;"> <div class="centerr btn btn-success">DETALLE</div> <div class="card-body""> <h4 class="card-title mb-1 text-dark">' + producto.nombreProducto +'</h4> <h5 class="mb-3 text-dark"> $' + producto.precioProducto +'<span style="color:grey"> o en dos cuotas de <span style="color:green">$' + producto.precioProducto / 2   + '</span></span></h5>  </div></div></div>');
                });                                

            },
        error:
            function(){
                console.log('error');
            }

        });
}