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
        private string _nombreUsuario, _descripcionConsulta;
        public Consulta(string pnombreUsuario, DateTime pfechaConsulta, string pdescripcionConsulta){
            _nombreUsuario = pnombreUsuario;
            _fechaConsulta = pfechaConsulta;
            _descripcionConsulta = pdescripcionConsulta;
        }
        public Consulta(){
            _nombreUsuario = "";
            _fechaConsulta = DateTime.MinValue;
            _descripcionConsulta = "";
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
    }
}