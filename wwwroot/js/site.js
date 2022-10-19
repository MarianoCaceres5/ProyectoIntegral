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
                $('.listaProductos').html(' ');
                resp.forEach(producto => {
                    $('.listaProductos').append('<div class="carousel-item active"><img alt="' +producto.idProducto + '" class="d-block imgProductoCarousel" src="' + producto.fotoProducto + '"> <div class="carousel-caption d-none d-md-block"><h3 class="text-dark">' + producto.nombreProducto +'</h3></div></div> ')
                                        
                });
                                

            },
        error:
            function(){
                console.log('error');
            }

        });
}