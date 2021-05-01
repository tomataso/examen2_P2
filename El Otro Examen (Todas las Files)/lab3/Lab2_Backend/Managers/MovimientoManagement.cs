using Lab3_Backend.DataAcces.Crud;
using Lab3_Backend.Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Backend.Managers
{
    public class MovimientoManagement
    {

        private MovimientoCrudFactory crudMovimiento;

        public MovimientoManagement()
        {
            crudMovimiento = new MovimientoCrudFactory();
        }

        public void Create(Movimiento movimiento)
        {

            crudMovimiento.Create(movimiento);

        }


        public List<Movimiento> RetrieveAll()
        {


            return crudMovimiento.RetrieveAll<Movimiento>();
        }

        public Movimiento RetrieveById(int id)
        {

            var movimiento = new Movimiento();
            movimiento.id_movimiento = id;
            return crudMovimiento.Retrieve<Movimiento>(movimiento);
        }

        public void Update(Movimiento movimiento)
        {
            crudMovimiento.Update(movimiento);
        }

        public void Delete(int id)
        {

            var movimiento = new Movimiento();
            movimiento.id_movimiento= id;


            crudMovimiento.Delete(movimiento);
        }
    }



}