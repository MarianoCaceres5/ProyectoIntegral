using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace TiendaJoyas.Models
{
    public class Carrito
    {
        private int _idCarrito, _idUsuario, _idProducto;
        private DateTime _fechaAgregadoACarrito;
        public Carrito(int pidUsuario, int pidProducto, DateTime pfechaAgregadoACarrito){
            _idUsuario = pidUsuario;
            _idProducto = pidProducto;
            _fechaAgregadoACarrito = pfechaAgregadoACarrito;
        }
        public Carrito(){
            _idUsuario = 0;
            _idProducto = 0;
            _fechaAgregadoACarrito = new DateTime(2014,10,23);
        }

        public int IdCarrito{
            get{return _idCarrito;}
        }
        public int IdUsuario{
            get{return _idUsuario;}
        }
        public int IdProducto{
            get{return _idProducto;}
        }
        public DateTime FechaAgregadoACarrito{
            get{return _fechaAgregadoACarrito;}
        }
    }
}