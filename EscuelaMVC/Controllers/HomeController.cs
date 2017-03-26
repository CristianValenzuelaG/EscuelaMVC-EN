using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EscuelaMVC.Models;
using EscuelaMVC.ViewModel;

namespace EscuelaMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Alumno> datos = AlumnoViewModel.Listar();
            ViewBag.datos = datos;
            return View();
        }

        public ActionResult VerDetalle(int id)
        {
            ViewBag.id = AlumnoViewModel.BuscarporID(id);
            return View();
        }
    }
}