using Lab3_Backend.DataAcces.Crud;
using Lab3_Backend.Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Backend.Managers
{
    public class CreditoManagment
    {

        private CreditoCrudFactory crudCredito;

        public CreditoManagment()
        {
            crudCredito = new CreditoCrudFactory();
        }

        public void Create(Credito credito)
        {
            crudCredito.Create(credito);
   
        }


        public List<Credito> RetrieveAll()
        {


            return crudCredito.RetrieveAll<Credito>();
        }

        public Credito RetrieveById(int id)
        {

            var credito = new Credito();
        credito.id_credito = id;
        
            return crudCredito.Retrieve<Credito>(credito);
        }

        public void Update(Credito credito)
        {
            crudCredito.Update(credito);
        }

        public void Delete(int id)
        {

            var credito = new Credito();
                        credito.id_credito = id;
       
            crudCredito.Delete(credito);
        }
    }



}