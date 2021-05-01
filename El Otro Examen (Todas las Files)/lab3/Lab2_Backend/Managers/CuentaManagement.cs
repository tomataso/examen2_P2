using Lab3_Backend.DataAcces.Crud;
using Lab3_Backend.Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Backend.Managers
{
    public class CuentaManagment
    {

        private CuentaCrudFactory crudCuenta;

        public CuentaManagment()
        {
            crudCuenta = new CuentaCrudFactory();
        }

        public void Create(Cuenta cuenta)
        {


            crudCuenta.Create(cuenta);



        }


        public List<Cuenta> RetrieveAll()
        {


            return crudCuenta.RetrieveAll<Cuenta>();
        }

        public Cuenta RetrieveById(int id)
        {
            var cuenta = new Cuenta();
            cuenta.id_cuenta = id;

            return crudCuenta.Retrieve<Cuenta>(cuenta);
        }

        public void Update(Cuenta cuenta)
        {

           

            crudCuenta.Update(cuenta);
        }

        public void Delete(int id)
        {

            var cuenta = new Cuenta();
            cuenta.id_cuenta = id;

            crudCuenta.Delete(cuenta);
        }
    }



}