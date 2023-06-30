using Microsoft.AspNetCore.Mvc;
using TP5Saladeescape.Models;
namespace TP5Saladeescape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tutorial()
    {
        
        return View();
    }
    public IActionResult Creditos()
    {
        
        return View();
    }
    public IActionResult Comenzar()
    {
        int estadoJuego = Escape.GetEstadoJuego();
        return View("habitacion" + estadoJuego);
        
    }
    public IActionResult Habitacion(int Sala, string clave)
    {
        int estadoJuego = Escape.GetEstadoJuego();

        if (Sala != estadoJuego)
        {
            return View("habitacion" + estadoJuego);
        }

        bool resultado = Escape.ResolverSala(Sala, clave);

        if (resultado == true)
        {
            estadoJuego++;
            Sala++;
            if (estadoJuego == 5){
                return View("victoria");
            }
            else{
                
                return View("habitacion" + estadoJuego);
            }
        }
        else
        {
            ViewBag.Error = "La respuesta ingresada es incorrecta.";
            return View("habitacion" + estadoJuego);
        }
    }
} 
