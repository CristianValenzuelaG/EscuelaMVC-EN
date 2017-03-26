using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EscuelaMVC.Models
{
    [Table(name:"Alumnos")]
    public class Alumno
    {
        [Key]
        public int pkAlumno { get; set; }
        [Required (ErrorMessage = "Error nombre incorrecto")]
        public string sNombre { get; set; }

        [Required(ErrorMessage = "Error apellido incorrecto")]
        public string sApellido { get; set; }

        [Required(ErrorMessage = "Error grupo incorrecto")]
        public string sGrupo { get; set; }

        public string sImagen { get; set; }
        public Boolean bStatus { get; set; }

        public Alumno()
        {
            bStatus = true;
        }
    }
}