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
        //esto va dentro de la carpeta manager 
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

        /// <summary>
        /// Se mandan a llamar los datos desde alumnosviwModel la cual recive los datos de la pagina al actualizar
        /// </summary>
        /// <param name="Datos"></param>
        public static void Actualizar(AlumnosViwModel Datos)
        {
            //se crean la funcion para buscar el alumno dependiendo de los datos
            Alumno tAlumno = BuscarporID(Datos.txtId);

            tAlumno.sNombre = Datos.txtNombre;
            tAlumno.sApellido = Datos.txtApellido;
            tAlumno.sGrupo = Datos.txtGrupo;

            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(tAlumno).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Borrar(int id )
        {
            //se crean la funcion para buscar el alumno dependiendo de los datos
            Alumno tAlumno = BuscarporID(id);

            tAlumno.bStatus = false;

            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Entry(tAlumno).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}