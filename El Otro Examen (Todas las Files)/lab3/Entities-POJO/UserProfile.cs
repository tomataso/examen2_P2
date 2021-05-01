using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class UserProfile : BaseEntity
    {
        public int Id_Usuario { get; set; }
        public string Apodo { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Uno { get; set; }
        public string Apellido_Dos { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Edad { get; set; }
        public string Foto { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public int Rol_Usuario_Id { get; set; }
        public string Contrasenna { get; set; }

        public UserProfile()
        {

        }
        public UserProfile(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 13)
            {
                var id_Usuario = 0;
                if (Int32.TryParse(infoArray[0], out id_Usuario))
                    Id_Usuario = id_Usuario;
                else
                    throw new Exception("Cedula must be a number");

                Apodo = infoArray[1];
                Estado = infoArray[2];
                Nombre = infoArray[3];
                Apellido_Uno = infoArray[4];
                Apellido_Dos = infoArray[5];

                var fecha_Nacimiento = DateTime.MinValue;
                if (DateTime.TryParse(infoArray[6], out fecha_Nacimiento))
                    Fecha_Nacimiento = fecha_Nacimiento;
                else
                    throw new Exception("Check In must be a datetime");

                var edad = 0;
                if (Int32.TryParse(infoArray[7], out edad))
                    Edad = edad;
                else
                    throw new Exception("Age must be a number");

                Foto = infoArray[8];
                Correo = infoArray[9];
                Celular = infoArray[10];
                var rol = 0;
                if (Int32.TryParse(infoArray[11], out rol))
                    Rol_Usuario_Id = rol;
                else
                    throw new Exception("Rol must be a number");

                Contrasenna = infoArray[12];

            }

            else
            {
                throw new Exception("All values are required");
            }
        }
    }
}
