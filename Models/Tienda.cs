using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;

namespace ProyectoIntegral.Models{

    public static class Tienda{                

        public static List<Categoria> ObtenerCategorias(){
            return BD.ObtenerCategorias();
        }            
        public static List<Producto> ObtenerProductos(){
            return BD.ObtenerProductos();
        }            

        public static List<Carrito> ObtenerCarrito(){
            return BD.ObtenerCarrito();
        }

        public static List<Producto> ObtenerProductosPorCategoria(int IdCategoria){
            List<Producto> listaProductos = BD.ObtenerProductosOrdenadosPorPrecio(IdCategoria);
            List<Producto> listaProductosPorCategoria = new List<Producto>();
            /*foreach(Producto prod in listaProductos){                
                if(prod.IdCategoria == IdCategoria){
                    listaProductosPorCategoria.Add(prod);
                }
            }       */



            //return listaProductosPorCategoria;
            return listaProductos;
        }

        public static Producto ObtenerProductoSeleccionado(int IdProducto){
            return BD.ObtenerProductoSeleccionado(IdProducto);
        }

    }
}