using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petalos.Models;

namespace Petalos.Controllers
{
    [Area("Admin")]
    //[Route("[controller]/[action]/")]
    public class AdminController : Controller
    {
       
        public floresContext Contexto { get; }
        public IWebHostEnvironment Host { get; }

        public AdminController(floresContext owo, IWebHostEnvironment host)
        {
            Contexto = owo;
            Host = host;
        }
        [Route("Admin")]
        [Route("Admin/Home")]
        [Route("Admin/Index")]
        public IActionResult Index()
        {
            var consulta = Contexto.Datosflores.OrderBy(x=>x.Nombre);
            return View(consulta);
        }
       
        public IActionResult AgregarFlor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarFlor(Datosflores aggFlor)
        {
            if (string.IsNullOrWhiteSpace(aggFlor.Nombre))
            {
                ModelState.AddModelError("", "Por favor escriba el nombre de la flor");
            }
            if (string.IsNullOrWhiteSpace(aggFlor.Nombrecientifico))
            {
                ModelState.AddModelError("", "Por favor escriba el nombre cientifico de la flor");
            }
            if (string.IsNullOrWhiteSpace(aggFlor.Nombrecomun))
            {
                ModelState.AddModelError("", "Por favor escriba el nombre comun de la flor");
            }
            if (string.IsNullOrWhiteSpace(aggFlor.Origen))
            {
                ModelState.AddModelError("", "Por favor escriba el origen de la flor");
            }
            if (string.IsNullOrWhiteSpace(aggFlor.Descripcion))
            {
                ModelState.AddModelError("", "Por favor escriba una descripcion para la flor");
            }
            if (Contexto.Datosflores.Any(x => x.Nombrecientifico == aggFlor.Nombrecientifico))
            {
                ModelState.AddModelError("", "Ya existe ese nombre cientifico");
            }
            else
            {
                Contexto.Add(aggFlor);
                Contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aggFlor);
        }
        public IActionResult AgregarImagenes(int id)
        {
            var consulta = Contexto.Datosflores.Include(x=>x.Imagenesflores).FirstOrDefault(x => x.Idflor==id);
            if (consulta==null)
            {
                return RedirectToAction("Index");
            }
            return View(consulta);
        }
        [HttpPost]
        public IActionResult AgregarImagenes(Datosflores aggImagen, IFormFile archivito)
        {
            var consulta = Contexto.Datosflores.Include(x=>x.Imagenesflores).FirstOrDefault(x => x.Idflor == aggImagen.Idflor);
            
            if (consulta==null)
            {
                return RedirectToAction("Index");
            }
            if (archivito==null)
            {
                ModelState.AddModelError("", "Por favor seleccione una imagen para la flor");
            }
            if (archivito!=null)
            {
                if (archivito.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("", "Por favor seleccione una imagen jpg");
                    return View(aggImagen);
                }
                var path = Host.WebRootPath + "/images/" + consulta.Imagenesflores.Where(x=>x.Idflor==aggImagen.Idflor);
                FileStream file = new FileStream(path, FileMode.Create);
                archivito.CopyTo(file);
                file.Close();
                Contexto.Add(consulta);
                Contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aggImagen);
        }
        public IActionResult EditarFlor(int id)
        {
            var consulta = Contexto.Datosflores.FirstOrDefault(x => x.Idflor == id);
            if (consulta == null)
            {
                return RedirectToAction("Index");
            }
            return View(consulta);
        }
        [HttpPost]
        public IActionResult EditarFlor(Datosflores florecita)
        {
            var consulta = Contexto.Datosflores.FirstOrDefault(x => x.Idflor == florecita.Idflor);
            if (consulta==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                consulta.Nombre = florecita.Nombre;
                consulta.Nombrecientifico = florecita.Nombrecientifico;
                consulta.Nombrecomun = florecita.Nombrecomun;
                consulta.Origen = florecita.Origen;
                consulta.Descripcion = florecita.Descripcion;
                Contexto.Update(consulta);
                Contexto.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public IActionResult EliminarFlor(int id)
        {
            var consulta = Contexto.Datosflores.FirstOrDefault(x => x.Idflor == id);
            if (consulta==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Contexto.Remove(consulta);
                Contexto.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public IActionResult EliminarImagenes(int id)
        {
            var consulta = Contexto.Imagenesflores.FirstOrDefault(x => x.Idflor == id);
            if (consulta == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Contexto.Remove(consulta);
                Contexto.SaveChanges();
                var path = Host.WebRootPath + "/images/" + consulta.Nombreimagen;
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                return RedirectToAction("Index");
            }
        }
    }
}