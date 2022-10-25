using System;
using System.Data;
using System.Net;
using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace ProyectoIntegral.Models{
    
    public class BD{        

        private static string server = Dns.GetHostName();
        private static string _connectionString = @$"Server={server}\SQLEXPRESS;DataBase=ProyectoIntegral;Trusted_Connection=True;";        

        public static List<Categoria> ObtenerCategorias(){
            List<Categoria> listaCategorias = new List<Categoria>();
            string SQL = "SELECT * FROM Categorias";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaCategorias = db.Query<Categoria>(SQL).ToList();
            }
            return listaCategorias;
        }
        public static Producto ObtenerProductoSeleccionado(int IdProducto){
            Producto productoSeleccionado = new Producto();
            string SQL = "SELECT * FROM Productos where IdProducto = @pIdProducto";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                productoSeleccionado = db.QueryFirstOrDefault<Producto>(SQL, new{pIdProducto = IdProducto});                
            }
            return productoSeleccionado;
        }    

        public static List<Producto> ObtenerProductos(){
            List<Producto> listaProductos = new List<Producto>();
            string SQL = "SELECT * FROM Productos";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaProductos = db.Query<Producto>(SQL).ToList();
            }
            return listaProductos;
        }    

        public static List<Producto> BuscarProductos(string Busqueda){
            List<Producto> listaProductos = new List<Producto>();
            string SQL = "SELECT * FROM Productos where NombreProducto like @pBusqueda";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaProductos = db.Query<Producto>(SQL, new{pBusqueda = Busqueda}).ToList();
            }
            return listaProductos;
        }    

        public static List<Producto> ObtenerProductosOrdenadosPorPrecio(int IdCategoria){
            List<Producto> listaProductos = new List<Producto>();
            string SQL = "SELECT TOP 5 * FROM Productos where IdCategoria = @pIdCategoria order by PrecioProducto desc";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaProductos = db.Query<Producto>(SQL, new{pIdCategoria = IdCategoria}).ToList();
            }
            return listaProductos;
        }    

        public static List<Carrito> ObtenerCarrito(){
            List<Carrito> listaCarrito = new List<Carrito>();
            string SQL = "SELECT * FROM Carritos";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaCarrito = db.Query<Carrito>(SQL).ToList();
            }
            return listaCarrito;
        }

        public static void AgregarConsulta(Consulta consulta){

            string SQL = "INSERT INTO Consultas(NombreUsuario, FechaConsulta, DescripcionConsulta) VALUES(@pNombreUsuario, @pFechaConsulta, @pDescripcionConsulta)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new {pNombreUsuario = consulta.NombreUsuario, pFechaConsulta = consulta.FechaConsulta, pDescripcionConsulta = consulta.DescripcionConsulta});
            }

        }

        public static void AgregarAlCarrito(Carrito carrito){
            string SQL = "INSERT INTO Carritos(IdProducto, FechaAgregadoACarrito, CantidadUnidades) VALUES(@pIdProducto, @pFechaAgregadoACarrito, @pCantidadUnidades)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new {pIdProducto = carrito.IdProducto, pFechaAgregadoACarrito = carrito.FechaAgregadoACarrito, pCantidadUnidades = carrito.CantidadUnidades});
            }
        }

        public static void EliminarDelCarrito(int IdProducto){
            string SQL = "DELETE FROM Carritos WHERE IdProducto = @pIdProducto";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new{pIdProducto = IdProducto});
            }
        }    

        public static void ActualizarCarrito(int IdProducto, int CantidadUnidades){
            string SQL = "UPDATE Carritos set CantidadUnidades = @pCantidadUnidades WHERE IdProducto = @pIdProducto";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new{pCantidadUnidades = CantidadUnidades, pIdProducto = IdProducto});
            }
        }    

        /*

        public static List<Dificultad> ObtenerDificultades(){
            List<Dificultad> listaDificultades = new List<Dificultad>();
            string SQL = "SELECT * FROM Dificultades";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaDificultades = db.Query<Dificultad>(SQL).ToList();
            }
            return listaDificultades;
        }

        public static List<Pregunta> ObtenerPreguntas(int dificultad, int categoria){
            
            List<Pregunta> listaPreguntas = new List<Pregunta>();
            string SQL = "SELECT * FROM Preguntas WHERE IdDificultad = @pIdDificultad AND IdCategoria = @pIdCategoria";    
            
            if(dificultad == -1 && categoria != -1){
                SQL = "SELECT * FROM Preguntas WHERE IdCategoria = @pIdCategoria";
            }
            else if(categoria == -1 && dificultad != -1){
                SQL = "SELECT * FROM Preguntas WHERE IdDificultad = @pIdDificultad";
            }else if(dificultad == -1 && categoria == -1){
                SQL = "SELECT * FROM Preguntas";
            }else{
                SQL = "SELECT * FROM Preguntas WHERE IdDificultad = @pIdDificultad AND IdCategoria = @pIdCategoria";
            }

            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaPreguntas = db.Query<Pregunta>(SQL, new{pIdDificultad = dificultad, pIdCategoria = categoria}).ToList();
            }
            return listaPreguntas;
        }

        public static List<Respuesta> ObtenerRespuestas(List<Pregunta> preguntas){
        
            List<Respuesta> listaRespuestas = new List<Respuesta>();
            
            foreach(Pregunta preg in preguntas){
                string SQL = "SELECT * FROM Respuestas WHERE IdPregunta = @pIdPregunta";
                using(SqlConnection db = new SqlConnection(_connectionString)){
                    listaRespuestas.AddRange(db.Query<Respuesta>(SQL, new{pIdPregunta = preg.IdPregunta}));
                }
            }
            return listaRespuestas;
        }

        public static void ActualizarContadorSeleccionada(int idRespuesta){
            string SQL = "UPDATE Respuestas SET ContadorSeleccionada = ContadorSeleccionada + 1 WHERE IdRespuesta = @pidRespuesta";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new{pidRespuesta = idRespuesta});
            }
        }

        public static List<Puntaje> ObtenerPuntajes(){
            List<Puntaje> listaPuntajes = new List<Puntaje>();
            string SQL = "SELECT TOP 8 * FROM Puntajes order by Puntos desc";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                listaPuntajes = db.Query<Puntaje>(SQL).ToList();
            }
            return listaPuntajes;
        }

        public static void AgregarPuntaje(Puntaje punt){

            string SQL = "INSERT INTO Puntajes(UserName, Puntos, FechaHora, Tiempo) VALUES(@pUserName, @pPuntos, @pFechaHora, @pTiempo)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new {pUserName = punt.UserName, pPuntos = punt.Puntos, pFechaHora = punt.FechaHora, pTiempo = punt.Tiempo});
            }
        }

        public static void AgregarPregunta(Pregunta preg){
            string SQL = "INSERT INTO Preguntas(IdCategoria, IdDificultad, Enunciado, Foto) VALUES(@pIdCategoria, @pIdDificultad, @pEnunciado, @pFoto)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new {pIdCategoria = preg.IdCategoria, pIdDificultad = preg.IdDificultad, pEnunciado = preg.Enunciado, pFoto = preg.Foto});
            }
        }

        public static void AgregarRespuesta(Respuesta resp){
            string SQL = "INSERT INTO Respuestas(IdPregunta, Opcion, Contenido, Correcta, Foto, ContadorSeleccionada) VALUES(@pIdPregunta, @pOpcion, @pContenido, @pCorrecta, @pFoto, @pContadorSeleccionada)";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new {pIdPregunta  = resp.IdPregunta, pOpcion = resp.Opcion, pContenido = resp.Contenido, pCorrecta = resp.Correcta, pFoto = resp.Foto, pContadorSeleccionada = resp.ContadorSeleccionada});
            }
        }

        public static void EliminarPregunta(int IdPregunta){            
            
            string SQL = "DELETE FROM Preguntas WHERE IdPregunta = @pIdPregunta";
            using(SqlConnection db = new SqlConnection(_connectionString)){
                db.Execute(SQL, new{pIdPregunta = IdPregunta});
            }
        } */


    }
}