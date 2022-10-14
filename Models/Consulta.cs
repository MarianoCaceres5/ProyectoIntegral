using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaJoyas.Models
{
    public class Consulta
    {
        private int _idConsulta, _idUsuario;
        private DateTime _fechaConsulta;
        private string _descripcionConsulta;
        public Consulta(int pidUsuario, DateTime pfechaConsulta, string pdescripcionConsulta){
            _idUsuario = pidUsuario;
            _fechaConsulta = pfechaConsulta;
            _descripcionConsulta = pdescripcionConsulta;
        }
        public Consulta(){
            _idUsuario = 0;
            _fechaConsulta = new DateTime(2014,10,23);
            _descripcionConsulta = "";
        }

        public int IdConsulta{
            get{return _idConsulta;}
        }
        public int IdUsuario{
            get{return _idUsuario;}
        }
        public DateTime FechaConsulta{
            get{return _fechaConsulta;}
        }
        public string DescripcionConsulta{
            get{return _descripcionConsulta;}
        }
    }
}