using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        public  IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación=2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre="Platzi School";
            escuela.Ciudad="Juarez";
            escuela.Pais = "Mexico";
            escuela.Dirección = "Calle trujillo 1313";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            
            ViewBag.CosaDinamica = "La Monja";

            return View(escuela);
        }
    }
}