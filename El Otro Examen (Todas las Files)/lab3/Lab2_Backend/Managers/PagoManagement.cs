using Lab3_Backend.DataAcces.Crud;
using Lab3_Backend.Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Backend.Managers
{
    public class PagoManagement
    {

        private PagoCrudFactory crudPago;

        public PagoManagement()
        {
            crudPago = new PagoCrudFactory();
        }

        public void Create(Pago pago)
        {

            crudPago.Create(pago);

        }


        public List<Pago> RetrieveAll()
        {


            return crudPago.RetrieveAll<Pago>();
        }

        public Pago RetrieveById(int id)
        {
            var pago = new Pago();
            pago.id_pago = id;

            return crudPago.Retrieve<Pago>(pago);
        }

        public void Update(Pago pago)
        {
            crudPago.Update(pago);
        }

        public void Delete(int id)
        {

            var pago = new Pago();
            pago.id_pago = id;


            crudPago.Delete(pago);
        }
    }



}