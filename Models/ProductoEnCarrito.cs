using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace ProyectoIntegral.Models
{
    public class ProductoEnCarrito
    {
        private int _idProductoEnCarrito, _cantUnidades;
        private Producto _producto = new Producto();

        public ProductoEnCarrito(Producto pproducto, int pcantUnidades){
            
            _producto = pproducto;
            _cantUnidades = pcantUnidades;
        }
        public ProductoEnCarrito(){
            
            _producto = new Producto();
            _cantUnidades = 0;
        }

        public int IdProductoEnCarrito{
            get{return _idProductoEnCarrito;}
            set{_idProductoEnCarrito = value;}
        }

        public Producto Producto{
            get{return _producto;}
            set{_producto = value;}
        }
        public int CantUnidades{
            get{return _cantUnidades;}
            set{_cantUnidades = value;}
        }

        
        

    }
}