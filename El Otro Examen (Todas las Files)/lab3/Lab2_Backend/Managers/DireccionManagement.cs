using Lab3_Backend.DataAcces.Crud;
using Lab3_Backend.Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Backend.Managers
{
    public class DireccionManagement
    {

        private DireccionCrudFactory crudDireccion;

        public DireccionManagement()
        {
            crudDireccion = new DireccionCrudFactory();
        }

        public void Create(Direccion direccion)
        {

            crudDireccion.Create(direccion);

        }


        public List<Direccion> RetrieveAll()
        {


            return crudDireccion.RetrieveAll<Direccion>();
        }

        public Direccion RetrieveById(int  id)
        {
            var direccion = new Direccion();
            direccion.id_direccion = id;

            return crudDireccion.Retrieve<Direccion>(direccion);
        }

        public void Update(Direccion direccion)
        {
            crudDireccion.Update(direccion);
        }

        public void Delete(int id)
        {

            var direccion = new Direccion();
            direccion.id_direccion = id;

            crudDireccion.Delete(direccion);
        }
    }



}