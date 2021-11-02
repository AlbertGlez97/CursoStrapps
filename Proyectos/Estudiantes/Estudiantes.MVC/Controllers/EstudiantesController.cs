using Estudiantes.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiantes.MVC.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly ILogger<EstudiantesController> _logger;

        public EstudiantesController(ILogger<EstudiantesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Listado()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View("Estudiantes");
        }
        public IActionResult Editar()
        {
            return View("Estudiantes");
        }
        public IActionResult Consultar()
        {
            return View("Estudiantes");
        }
    }
}
