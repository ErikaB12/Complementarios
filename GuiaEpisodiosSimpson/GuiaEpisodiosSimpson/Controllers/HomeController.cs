using Microsoft.AspNetCore.Mvc;
using System.Linq;
using GuiaEpisodiosSimpson.Models;
using Microsoft.EntityFrameworkCore;

namespace GuiaEpisodiosSimpson.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            simpsonContext uwu= new simpsonContext();
            var owo = uwu.Temporada.OrderBy(x => x.Id);
            ViewBag.Contarowo = uwu.Episodios.GroupBy(x => x.IdTemporada).Count();
            return View(owo);
        }

        [Route("Info-Temporada-{id}")]
        public IActionResult Info(int id)
        {
            simpsonContext uwu= new simpsonContext();
            var owo = uwu.Episodios.Include(x=>x.IdTemporadaNavigation).Where(x => x.IdTemporada==id).OrderBy(x=>x.Id);
            if (owo==null)
            {
                return RedirectToAction("Index");
            }
            return View(owo);
        }
    }
}
