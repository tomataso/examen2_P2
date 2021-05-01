using Entities_POJO;
using System;

namespace Lab3_Backend.Entities_POJO
{
    public class Pago : BaseEntity
    {
        public int id_pago { get; set; }
        public DateTime fecha_pago { get; set; }
        public decimal monto { get; set; }
        public int credito_id { get; set; }
    }

}


