using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petalos.Models;
using Petalos.Models.ViewModels;

namespace Petalos.Controllers
{
    public class HomeController : Controller
    {
        public floresContext Contexto { get; }

        public HomeController(floresContext owo)
        {
            Contexto = owo;
        }
        public IActionResult Index()
        {
            var consulta = Contexto.Datosflores.OrderBy(x => x.Nombre);
            return View(consulta);
        }
        [Route("Datos-de-la-flor/{nombre}")]
        public IActionResult Flor(string nombre)
        {
            var consulta = Contexto.Datosflores.Include(x=>x.Imagenesflores).FirstOrDefault(x => x.Nombre == nombre);
            Random r = new Random();
            RecomendacionesViewModel recomendaciones = new RecomendacionesViewModel();
            recomendaciones.Datosflores = consulta;
            recomendaciones.Recomendacion = Contexto.Datosflores.Where(x => x.Nombre != consulta.Nombre).ToList().OrderBy(x=>r.Next());
            return View(recomendaciones);
        }
    }
}