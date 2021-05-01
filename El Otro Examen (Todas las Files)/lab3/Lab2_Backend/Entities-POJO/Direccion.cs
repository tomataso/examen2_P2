using Entities_POJO;

namespace Lab3_Backend.Entities_POJO
{
    public class Direccion : BaseEntity
    {
        public int id_direccion { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }
        public string detalles { get; set; }
        public string cliente_id { get; set; }
    }

}


