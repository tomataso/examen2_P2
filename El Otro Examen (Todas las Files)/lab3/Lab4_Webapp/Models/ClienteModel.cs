using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_Webapp.Models
{
    public class ClienteModel
    {

        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fecha_nacimiento { get; set; }
        public int edad { get; set; }
        public string estado_civil { get; set; }
        public string genero { get; set; }

    }
}