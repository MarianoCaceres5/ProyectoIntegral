 using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace ProyectoIntegral.Models{
    public class Usuario{
        
        private int _idUsuario;   
        public string _emailUsuario, _nombreUsuario, _contrasenaUsuario, _fotoUsuario;    
        public Usuario(string pemailUsuario, string pnombreUsuario, string pcontrasenaUsuario, string pfotoUsuario){    
            
            _emailUsuario = pemailUsuario;
            _nombreUsuario = pnombreUsuario;
            _contrasenaUsuario = pcontrasenaUsuario;
            _fotoUsuario = pfotoUsuario;
        }
        public Usuario(){
            
            
            _emailUsuario = "";
            _nombreUsuario = "";
            _contrasenaUsuario = "";
            _fotoUsuario = "";
        }
    
        public int IdUsuario{
            get{return _idUsuario;}
            set{_idUsuario = value;}
        }       
        public string EmailUsuario{
            get{return _emailUsuario;}
            set{_emailUsuario = value;}
        }
        public string NombreUsuario{
            get{return _nombreUsuario;}
            set{_nombreUsuario = value;}
        }
        public string ContrasenaUsuario{
            get{return _contrasenaUsuario;}
            set{_contrasenaUsuario = value;}
        }
        public string FotoUsuario{
            get{return _fotoUsuario;}
            set{_fotoUsuario = value;}
        }


    }
}