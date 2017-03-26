using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Runtime.InteropServices.ComTypes;
using EscuelaMVC.Models;

namespace EscuelaMVC.ViewModel
{
    public class AlumnoViewModel
    {
        public static List<Alumno> Listar()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Alumnos.Where(r => r.bStatus == true).ToList();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public static Alumno BuscarporID(int pkAlumno)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Alumnos.Where(r => r.pkAlumno == pkAlumno).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}