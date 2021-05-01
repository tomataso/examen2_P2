using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Propiedad: BaseEntity 
    {
        public int Id_Propiedad { get; set; }
        public string Foto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id_Direccion { get; set; }
        public int Id_Empresa { get; set; }

        public Propiedad()
        {

        }
        public Propiedad(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 6)
            {

                var id_Propiedad = 0;
                if (Int32.TryParse(infoArray[0], out id_Propiedad))
                    Id_Propiedad = id_Propiedad;
                else
                    throw new Exception("Id_Propiedad must be a number");
                Foto = infoArray[1];
                Nombre = infoArray[2];
                Descripcion = infoArray[3];

                var id_Direccion = 0;
                if (Int32.TryParse(infoArray[4], out id_Direccion))
                    Id_Direccion = id_Direccion;
                else
                    throw new Exception("Id_Direccion must be a number");

                var id_Empresa = 0;
                if (Int32.TryParse(infoArray[5], out id_Empresa))
                    Id_Empresa = id_Empresa;
                else
                    throw new Exception("Id_Empresa must be a number");
            }

            else
            {
                throw new Exception("All values are required");
            }
        }
    }
}
