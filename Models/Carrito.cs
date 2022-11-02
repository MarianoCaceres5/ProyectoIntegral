using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace ProyectoIntegral.Models{
    public class Carrito{
        
        private int _idCarrito, _idProducto, _cantidadUnidades, _idUsuario;
        private DateTime _fechaAgregadoACarrito;
        public Carrito(int pidProducto, DateTime pfechaAgregadoACarrito, int pcantidadUnidades, int pidUsuario){
            
            _idProducto = pidProducto;
            _fechaAgregadoACarrito = pfechaAgregadoACarrito;
            _cantidadUnidades = pcantidadUnidades;
            _idUsuario = pidUsuario;
        }
        public Carrito(){
            
            _idProducto = 0;
            _fechaAgregadoACarrito = DateTime.MinValue;
            _cantidadUnidades = 0;
            _idUsuario = 0;
        }
    
        public int IdCarrito{
            get{return _idCarrito;}
            set{_idCarrito = value;}
        }       
        public int IdProducto{
            get{return _idProducto;}
            set{_idProducto = value;}
        }
        public DateTime FechaAgregadoACarrito{
            get{return _fechaAgregadoACarrito;}
            set{_fechaAgregadoACarrito = value;}
        }

        public int CantidadUnidades{
            get{return _cantidadUnidades;}
            set{_cantidadUnidades = value;}
        }

        public int IdUsuario{
            get{return _idUsuario;}
            set{_idUsuario = value;}
        }

    }
}