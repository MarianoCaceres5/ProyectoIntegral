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
            
            Random random = new Random();       
            int indiceAleatorio;

            List<Producto> listaProductos = BD.ObtenerProductos();
            int longitudLista = listaProductos.Count();

            for(int i = 0; i < longitudLista; i++){
                indiceAleatorio = random.Next(0,longitudLista);
                Producto temporal = listaProductos[indiceAleatorio];
                listaProductos[indiceAleatorio] = listaProductos[i];
                listaProductos[i] = temporal;         
            }  
            return listaProductos;

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