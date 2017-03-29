using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EscuelaMVC.Comun;
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

        public ActionResult getImagen(int id)
        {
            Alumno temAlumno = AlumnoViewModel.BuscarporID(id);
            var temImage = ToolImage.Base64StringToBitmap(temAlumno.sImagen);
            var temMapBytes = ToolImage.BitmapToBytes(temImage);

            return File(temMapBytes, "image/jpeg");
        }


        public ActionResult frmActualizacion(int id)
        {
            ViewBag.id = AlumnoViewModel.BuscarporID(id);
            
            return View();
        }

        //public ActionResult Actualizar(int txtId, string txtNombre, string txtApellido, string txtGrupo)
        //{

        //    return View();
        //}

        public ActionResult Actualizar(AlumnosViwModel Datos)
        {
            AlumnoViewModel.Actualizar(Datos);
            return View();
        }

        public ActionResult Borrar(int id)
        {
            ViewBag.Dato = AlumnoViewModel.BuscarporID(id);
            return View();
        }

        public ActionResult Borrar2(int txtId)
        {
            AlumnoViewModel.Borrar(txtId);
            return View();
        }
    }
}