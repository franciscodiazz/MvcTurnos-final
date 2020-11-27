using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcTurnos.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {

            ViewData["Message"] = "";
            return RedirectToAction("Create", "Turnos");

        }
        public IActionResult RegistrarDatos()
        {
            return RedirectToAction("Create", "Usuarios");
        }
        public IActionResult CambiarTurno()
        {
            return View("CambiarTurno");


        }
        public IActionResult EliminarTurno()
        {
            return View("EliminarTurno");

        }
        public IActionResult Certificado()
        {
            return View("Certificado");

        }

        // 
        // GET: /HelloWorld/Welcome/ 

    }
}