using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace ProyectoIntegral.Models
{
    public class Producto
    {
        private int _idProducto, _precioProducto, _idCategoria;
        private string _nombreProducto, _fotoProducto, _materialProducto, _descripcionProducto;

        public Producto(string pnombreProducto, int pprecioProducto, int pidCategoria, string pfotoProducto, string pMaterialProducto, string pdescripcionProducto){
            _nombreProducto = pnombreProducto;
            _precioProducto = pprecioProducto;
            _idCategoria = pidCategoria;
            _fotoProducto = pfotoProducto;
            _materialProducto = pMaterialProducto;
            _descripcionProducto = pdescripcionProducto;
        }
        public Producto(){
            _nombreProducto = "";
            _precioProducto = 0;
            _idCategoria = 0;
            _fotoProducto = "";
            _materialProducto = "";
            _descripcionProducto = "";
        }

        public int IdProducto{
            get{return _idProducto;}
            set{_idProducto = value;}
        }

        public string NombreProducto{
            get{return _nombreProducto;}
            set{_nombreProducto = value;}
        }
        public int PrecioProducto{
            get{return _precioProducto;}
            set{_precioProducto = value;}
        }
        public int IdCategoria{
            get{return _idCategoria;}
            set{_idCategoria = value;}
        }
        public string FotoProducto{
            get{return _fotoProducto;}
            set{_fotoProducto = value;}
        }
        public string MaterialProducto{
            get{return _materialProducto;}
            set{_materialProducto = value;}
        }
        public string DescripcionProducto{
            get{return _descripcionProducto;}
            set{_descripcionProducto = value;}
        }

    }
}