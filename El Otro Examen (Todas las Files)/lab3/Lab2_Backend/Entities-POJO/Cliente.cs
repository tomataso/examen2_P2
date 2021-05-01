using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Backend.Entities_POJO
{
    public class Cliente : BaseEntity
    {


        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public int edad { get; set; }
        public string estado_civil { get; set; }
        public string genero { get; set; }



    }


    

}


