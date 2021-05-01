using Entities_POJO;
using System;

namespace Lab3_Backend.Entities_POJO
{
    public class Movimiento : BaseEntity
    {
        public int id_movimiento { get; set; }
        public DateTime fecha_movimiento { get; set; }
        public string tipo { get; set; }
        public decimal monto { get; set; }
        public int cuenta_id { get; set; }
    }

}


