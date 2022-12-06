using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOVIES_UDB.Models;

namespace MOVIES_UDB.Controllers
{
    public class HomeController : Controller
    {
        PeliculasBL _bl = new PeliculasBL();
        public ActionResult Index()
        {


            ViewBag.ListaPeliculas = _bl.ConsultarPeliculas().ToList();
            return View();


        }

        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(PeliculasEN pEN)
        {
            _bl.AgregarPelicula(pEN);
            return RedirectToAction("Index");

        }

    }
}