using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace TiendaJoyas.Models
{
    public class Categoria
    {
        private int _idCategoria;
        private string _nombreCategoria, _fotoCategoria;
        public Categoria(string pnombreCategoria, string pfotoCategoria){
            _nombreCategoria = pnombreCategoria;
            _fotoCategoria = pfotoCategoria;
        }
        public Categoria(){
            _nombreCategoria = "";
            _fotoCategoria = "";
        }

        public int IdCategoria{
            get{return _idCategoria;}
        }

        public string NombreCategoria{
            get{return _nombreCategoria;}
        }
        public string FotoCategoria{
            get{return _fotoCategoria;}
        }


    }
}