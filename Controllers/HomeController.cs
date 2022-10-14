using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TiendaJoyas.Models;

namespace TiendaJoyas.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Login");
    }    
    public IActionResult Inicio()
    {
        return View();
    }

    public IActionResult Productos()
    {
        return View();
    }

    public IActionResult Contacto()
    {
        return View();
    }

    public IActionResult Carrito()
    {
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
