using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace ProyectoIntegral.Models
{
    public class Consulta
    {
        private int _idConsulta;
        private DateTime _fechaConsulta;
        private string _nombreUsuario, _emailUsuario, _descripcionConsulta;
        public Consulta(string pnombreUsuario, DateTime pfechaConsulta, string pdescripcionConsulta, string pemailUsuario){
            _nombreUsuario = pnombreUsuario;
            _fechaConsulta = pfechaConsulta;
            _descripcionConsulta = pdescripcionConsulta;
            _emailUsuario = pemailUsuario;
        }
        public Consulta(){
            _nombreUsuario = "";
            _fechaConsulta = DateTime.MinValue;
            _descripcionConsulta = "";
            _emailUsuario = "";
        }

        public int IdConsulta{
            get{return _idConsulta;}
            set{_idConsulta = value;}
        }
        public string NombreUsuario{
            get{return _nombreUsuario;}
            set{_nombreUsuario = value;}
        }
        public DateTime FechaConsulta{
            get{return _fechaConsulta;}
            set{_fechaConsulta = value;}
        }
        public string DescripcionConsulta{
            get{return _descripcionConsulta;}
            set{_descripcionConsulta = value;}
        }
        public string EmailUsuario{
            get{return _emailUsuario;}
            set{_emailUsuario = value;}
        }
    }
}