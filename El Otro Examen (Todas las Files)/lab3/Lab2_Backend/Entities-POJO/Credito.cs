using Entities_POJO;
using System;

namespace Lab3_Backend.Entities_POJO
{
    public class Credito : BaseEntity
    {
        public int id_credito { get; set; }
        public decimal monto { get; set; }
        public decimal tasa { get; set; }
        public string nombre_linea { get; set; }
        public decimal cuota { get; set; }
        public DateTime fecha_inicio { get; set; }
        public string estado { get; set; }
        public decimal saldo { get; set; }
        public string cliente_id { get; set; }
    }


}


