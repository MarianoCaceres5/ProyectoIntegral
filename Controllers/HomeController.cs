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
        return View();
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
