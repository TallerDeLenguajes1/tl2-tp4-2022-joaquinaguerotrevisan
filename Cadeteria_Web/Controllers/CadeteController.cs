using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadeteria_Web.Models;

namespace Cadeteria_Web.Controllers
{
    [Route("[controller]")]
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;
        private static List<Cadete> Lista_Cadete = new List<Cadete>();

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Mostrar_Lista()
        {
            return View(Lista_Cadete);
        }

        [HttpPost]
        public IActionResult Alta_Cadete(int _Id, string? _Name, string? _Domic, string? _Tel)
        {
            Lista_Cadete.Add(new Cadete(_Id, _Name, _Domic, _Tel));

            return View();
        }

        [HttpPost]
        public IActionResult Baja_Cadete(int _Id_Cadete)
        {
            Cadete? Cadete_Buscar = Lista_Cadete.Find( Cadete => Cadete.Get_Id() == _Id_Cadete);

            if (Cadete_Buscar != null) 
            {
                Lista_Cadete.Remove(Cadete_Buscar);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}