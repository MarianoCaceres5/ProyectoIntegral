using System;
using System.Data;
using System.Net;
using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace PreguntadORT.Models{    
    public class BD{        
        private static string server = Dns.GetHostName();
        private static string _connectionString = @$"Server={server};DataBase=TIENDAJOYAS;Trusted_Connection=True;";  

        public static List<Producto> ObtenerProductos(){
            List<Producto> listaProductos = new List<Producto>();
            string SQL = "SELECT * FROM Productos";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaProductos = db.Query<Producto>(SQL).ToList();
            }
            return listaProductos;
        }
        public static List<Categoria> ObtenerCategorias(){
            List<Categoria> listaCategorias = new List<Categoria>();
            string SQL = "SELECT * FROM Categorias";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaCategorias = db.Query<Categoria>(SQL).ToList();
            }
            return listaCategorias;
        }

        public static Usuario ObtenerUsuario(string MailUsuario, string ContraseñaUsuario){
            Usuario miUsuario;
            string SQL = "SELECT * FROM Usuarios WHERE MailUsuario = @pMailUsuario AND ContraseñaUsuario = @pContraseñaUsuario";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                miUsuario = db.QueryFirstOrDefault<Usuario>(SQL, new{pMailUsuario = MailUsuario, pContraseñaUsuario = ContraseñaUsuario});
            }
            return miUsuario;
        }

        public static List<Carrito> ObtenerCarrito(int IdUsuario){
            List<Carrito> listaCarrito = new List<Carrito>();
            string SQL = "SELECT * FROM Carritos WHERE IdUsuario = @pIdUsuario";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaCarrito.AddRange(db.Query<Carrito>(SQL, new{pIdUsuario = IdUsuario}));
            }
            return listaCarrito;
        }

        public static void AgregarConsulta(Consulta consulta){

            string SQL = "INSERT INTO Consultas(IdUsuario, FechaConsulta, DescripcionConsulta) VALUES(@pIdUsuario, @pFechaConsulta, @pDescripcionConsulta)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new {pIdUsuario = consulta.IdUsuario, pFechaConsulta = consulta.FechaConsulta, pDescripcionConsulta = consulta.DescripcionConsulta});
            }

        }

        public static void AgregarAlCarrito(Carrito carrito){
            string SQL = "INSERT INTO Carritos(IdUsuario, IdProducto, FechaAgregadoACarrito) VALUES(@pIdUsuario, @pIdProducto, @pFechaAgregadoACarrito)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new {pIdUsuario = carrito.IdUsuario, pIdProducto = carrito.IdProducto, pFechaAgregadoACarrito = carrito.FechaAgregadoACarrito});
            }
        }   

        public static void AgregarUsuario(Usuario usuario){

            //EN EL CONTROLLER Y VISTAS VERIFICAR QUE EL USUARIO CON ESE MAIL NO EXISTE
            string SQL = "INSERT INTO Usuarios(NombreUsuario, MailUsuario, ContraseñaUsuario, EdadUsuario, FotoUsuario) VALUES(@pNombreUsuario, @pMailUsuario, @pContraseñaUsuario, @pEdadUsuario, @pFotoUsuario)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new {pNombreUsuario = usuario.NombreUsuario, pMailUsuario = usuario.MailUsuario, pContraseñaUsuario = usuario.ContraseñaUsuario, pEdadUsuario = usuario.EdadUsuario, pFotoUsuario = usuario.FotoUsuario});
            }

        }

        public static void EliminarDelCarrito(int IdProducto){
            string SQL = "DELETE FROM Carritos WHERE IdProducto = @pIdProducto";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new{pIdProducto = IdProducto});
            }
        }        

        /*public static void ActualizarContadorSeleccionada(int idRespuesta){
            string SQL = "UPDATE Respuestas SET ContadorSeleccionada = ContadorSeleccionada + 1 WHERE IdRespuesta = @pidRespuesta";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new{pidRespuesta = idRespuesta});
            }
        } */




    }
}