using System.Collections.Generic;
using System.Timers;
using System;
using System.Net;
using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProyectoIntegral.Models;
using System.Linq.Expressions;
using System.IO;
using Microsoft.AspNetCore.Hosting;

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
        ViewBag.Categorias = Tienda.ObtenerCategorias();       
        ViewBag.Productos = Tienda.ObtenerProductos(); 
        return View();
    }    

    public IActionResult Productos(){
        ViewBag.Categorias = Tienda.ObtenerCategorias();       
        ViewBag.Productos = Tienda.ObtenerProductos(); 
        return View();
    }

    public IActionResult Contacto(){        
        return View("Contacto");
    }

    public IActionResult GuardarConsulta(string NombreUsuario, string EmailUsuario, string DescripcionConsulta){
        DateTime FechaConsulta = DateTime.Now;
        Consulta consulta = new Consulta(NombreUsuario, FechaConsulta, DescripcionConsulta, EmailUsuario);
        BD.AgregarConsulta(consulta);
        return View("Contacto");
    }

    public IActionResult Carrito(){
        ViewBag.Carrito = Tienda.ObtenerCarrito();
        return View();
    }

    public List<Producto> MostrarProductosPorCategoria(int IdCategoria){
        return Tienda.ObtenerProductosPorCategoria(IdCategoria);
    }

    public Producto ModalProducto(int IdProducto){
        return BD.ObtenerProductoSeleccionado(IdProducto);
    }

    public void AgregarAlCarrito (int IdProducto){
        bool carritoActualizado = false;
        List<Carrito> carritos = BD.ObtenerCarrito();
        foreach(Carrito carr in carritos){
            if(IdProducto == carr.IdProducto){
                BD.ActualizarCarrito(IdProducto, (carr.CantidadUnidades+1));
                carritoActualizado = true;
            }
        }
        if(carritoActualizado == false){
            DateTime fechaAgregado = DateTime.Now;        
            int CantUnidades = 1;
            Carrito carrito = new Carrito(IdProducto, fechaAgregado, CantUnidades);
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
