using System.Collections;
using System;
using System.Collections.Generic;
using System.Timers;
using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProyectoIntegral.Models;
using System.Linq.Expressions;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net;


namespace ProyectoIntegral.Controllers;

public class HomeController : Controller
{
    private IWebHostEnvironment Environment;
    private readonly ILogger<HomeController> _logger;
    public HomeController(IWebHostEnvironment _environment)
    {        
        Environment = _environment;
    }

    public IActionResult Index()
    {                
        return View("Login");
    }    

    [HttpPost] public IActionResult IniciarSesion(string EmailUsuario, string ContrasenaUsuario)
    {                
        bool InicioSesionCorrecto = Tienda.IniciarSesion(EmailUsuario, ContrasenaUsuario);        
        ViewBag.InicioSesionCorrecto = InicioSesionCorrecto;
        if(InicioSesionCorrecto == true){            
            return RedirectToAction("Inicio","Home");
        }else{            
            return View("Login");
        }
        
    }    

    public IActionResult Registrarse(){   
        ViewBag.RegistroCorrecto = true;     
        return View();
    }

    [HttpPost] public IActionResult GuardarRegistro(string EmailUsuario, string NombreUsuario, string ContrasenaUsuario, IFormFile FotoUsuario){
        
        if(FotoUsuario.Length > 0)
        {
            string wwwRootLocal = this.Environment.ContentRootPath + @"\wwwroot\fotosUsuarios\" + FotoUsuario.FileName;
            using(var stream = System.IO.File.Create(wwwRootLocal)){
                
                FotoUsuario.CopyToAsync(stream);
            }
        } 

        if(Tienda.UsuarioExistente(EmailUsuario) == true){
            ViewBag.RegistroCorrecto = false;
            return View("Registrarse");
        }else{
            Usuario newUsuario = new Usuario(EmailUsuario, NombreUsuario, ContrasenaUsuario, ("/fotosUsuarios/" + FotoUsuario.FileName));
            BD.AgregarUsuario(newUsuario);
            bool InicioSesionCorrecto = Tienda.IniciarSesion(EmailUsuario, ContrasenaUsuario);  
            return RedirectToAction("Inicio","Home");  
        }

            
    }

    /*

    public void MandarMail(string EmailUsuario){

        string EmailOrigen = "nanocaceres2005@gmail.com";
        string EmailDestino = EmailUsuario;
        string Contraseña = "mariano15";

        MailMessage oMailMessage = new MailMessage(EmailOrigen, EmailDestino, "Hola asunto", "<p>Este es el mensaje</p>");  
        oMailMessage.IsBodyHtml = true;      

        SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com");
        oSmtpClient.EnableSsl = true;
        oSmtpClient.UseDefaultCredentials = false;
        oSmtpClient.Host = "smtp.gmail.com";
        oSmtpClient.Port = 587;
        oSmtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Contraseña);

        oSmtpClient.Send(oMailMessage);
        oSmtpClient.Dispose();

    } */

    public IActionResult CerrarSesion(){
        Tienda.Usuario = new Usuario();
        Tienda.InicioSesion = false;
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Inicio()
    {        
        ViewBag.Categorias = Tienda.ObtenerCategorias();       
        ViewBag.Productos = Tienda.ObtenerProductos(); 
        return View();
    }    

    public IActionResult Productos(){
        ViewBag.Categorias = Tienda.ObtenerCategorias();       
        ViewBag.Productos = Tienda.ObtenerProductos(); 
        return View();
    }

    public IActionResult Usuario(){
        if(Tienda.InicioSesion == false){
            return View("Login");
        }else{
            return RedirectToAction("Inicio", "Home");
        }
    }

    public IActionResult Contacto(){        
        return View("Contacto");
    }

    public IActionResult GuardarConsulta(string NombreUsuario, string DescripcionConsulta){
        DateTime FechaConsulta = DateTime.Now;
        Consulta consulta = new Consulta(NombreUsuario, FechaConsulta, DescripcionConsulta, Tienda.Usuario.IdUsuario);
        BD.AgregarConsulta(consulta);
        return View("Contacto");
    }

    public List<ProductoEnCarrito> ObtenerCarrito(){
        return Tienda.ObtenerCarrito();        
    }

    public List<ProductoEnCarrito> EliminarDelCarrito(int IdProducto){
        BD.EliminarDelCarrito(IdProducto);
        return Tienda.ObtenerCarrito();   
    }

    public List<Producto> MostrarProductosPorCategoria(int IdCategoria){
        return Tienda.ObtenerProductosPorCategoria(IdCategoria);
    }

    public Producto ModalProducto(int IdProducto){
        return BD.ObtenerProductoSeleccionado(IdProducto);
    }

    public void AgregarAlCarrito (int IdProducto){
        bool carritoActualizado = false;
        List<Carrito> carritos = BD.ObtenerCarrito(Tienda.Usuario.IdUsuario);
        foreach(Carrito carr in carritos){
            if(IdProducto == carr.IdProducto){
                BD.ActualizarCarrito(IdProducto, (carr.CantidadUnidades+1));
                carritoActualizado = true;
            }
        }
        if(carritoActualizado == false){
            DateTime fechaAgregado = DateTime.Now;        
            int CantUnidades = 1;
            Carrito carrito = new Carrito(IdProducto, fechaAgregado, CantUnidades, Tienda.Usuario.IdUsuario);
            BD.AgregarAlCarrito(carrito);
        }
        
    }

    public List<Producto> BuscarProductos(string Busqueda){
        Busqueda = '%' + Busqueda + '%';
        return BD.BuscarProductos(Busqueda);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
