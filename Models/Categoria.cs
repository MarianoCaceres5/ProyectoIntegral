using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace ProyectoIntegral.Models{
    public class Categoria{
        
        private int _idCategoria;
        private string _nombreCategoria;
        private string _fotoCategoria;

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
            set{_idCategoria = value;}
        }

        public string NombreCategoria{
            get{return _nombreCategoria;}
            set{_nombreCategoria = value;}
        }  

        public string FotoCategoria{
            get {return _fotoCategoria;}
            set{_fotoCategoria = value;}
        }


    }
}