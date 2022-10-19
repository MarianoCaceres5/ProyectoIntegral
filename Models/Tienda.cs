using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;

namespace ProyectoIntegral.Models{

    public static class Tienda{        
        private static List<Producto> _productos = new List<Producto>();
        private static List<Carrito> _carrito = new List<Carrito>();        
        

        public static List<Producto> Productos{
            get{return _productos;}            
        }

        public static List<Carrito> Carrito{
            get{return _carrito;}
        }     

        public static List<Categoria> ObtenerCategorias(){
            return BD.ObtenerCategorias();
        }            
        public static List<Producto> ObtenerProductos(){
            return BD.ObtenerProductos();
        }            

    }
}