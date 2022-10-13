using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace TiendaJoyas.Models{
    public class Usuario{
        
        private int _idUsuario, _edadUsuario;
        private string _nombreUsuario, _mailUsuario, _contraseñaUsuario, _fotoUsuario;
        
        public Usuario(string pnombreUsuario, string pmailUsuario, string pcontraseñaUsuario, int pedadUsuario, string pfotoUsuario){

            _nombreUsuario = pnombreUsuario;
            _mailUsuario = pmailUsuario;
            _contraseñaUsuario = pcontraseñaUsuario;
            _edadUsuario = pedadUsuario;
            _fotoUsuario = pfotoUsuario;

        }

        public Usuario(){
           
            _nombreUsuario = "";
            _mailUsuario = "";
            _contraseñaUsuario = "";
            _edadUsuario = 0;
            _fotoUsuario = "";
        }

        public int IdUsuario{
            get{return _idUsuario;}
        }

        public string NombreUsuario{
            get{return _nombreUsuario;}
        }

        public string MailUsuario{
            get{return _mailUsuario;}
        }

        public string ContraseñaUsuario{
            get{return _contraseñaUsuario;}
        }
        public int EdadUsuario{
            get{return _edadUsuario;}
        }
        public string FotoUsuario{
            get{return _fotoUsuario;}
        }
        

    }
}