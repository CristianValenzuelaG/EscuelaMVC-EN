using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscuelaMVC.ViewModel
{
    public class AlumnosViwModel
    {
        /// <summary>
        /// Estos datos los mando para el actualizar
        /// para que los datos que estoy mandando sean llamadaos igual que el input
        /// </summary>
        //int txtId, string txtNombre, string txtApellido, string txtGrupo
        public  int txtId { get; set; }
        public string txtNombre { get; set; }
        public string txtApellido { get; set; }
        public string txtGrupo { get; set; }
    }
}