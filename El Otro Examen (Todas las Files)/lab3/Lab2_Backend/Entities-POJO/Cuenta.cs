using Entities_POJO;

namespace Lab3_Backend.Entities_POJO
{
    public class Cuenta : BaseEntity
    {
        public int id_cuenta { get; set; }
        public string moneda { get; set; }
        public string tipo { get; set; }
        public decimal saldo { get; set; }
        public string cliente_id { get; set; }
    }

}


