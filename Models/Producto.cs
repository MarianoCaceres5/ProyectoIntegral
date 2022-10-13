using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaJoyas.Models
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
        }

        public string NombreProducto{
            get{return _nombreProducto;}
        }
        public int PrecioProducto{
            get{return _precioProducto;}
        }
        public int IdCategoria{
            get{return _idCategoria;}
        }
        public string FotoProducto{
            get{return _fotoProducto;}
        }
        public string MaterialProducto{
            get{return _materialProducto;}
        }
        public string DescripcionProducto{
            get{return _descripcionProducto;}
        }




    }
}