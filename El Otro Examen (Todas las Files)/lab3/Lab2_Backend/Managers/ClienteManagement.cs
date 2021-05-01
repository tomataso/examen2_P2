using Lab3_Backend.DataAcces.Crud;
using Lab3_Backend.Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Backend.Managers
{
   public class ClienteManagment
    {

        private ClienteCrudFactory crudCliente;

        public ClienteManagment()
        {
            crudCliente = new ClienteCrudFactory();
        }

        public void Create(Cliente cliente)
        {

            if (cliente.edad < 18)
            {
                throw new Exception("Cliente debe ser mayor de edad");
            }
            else
            {
                crudCliente.Create(cliente);

    
            }

        }


        public List<Cliente> RetrieveAll()
        {

           
            return crudCliente.RetrieveAll<Cliente>();
        }

        // revisar ESTO para otras funciones
        public Cliente RetrieveById(string id)
        {
            var cliente = new Cliente();
            cliente.cedula = id;

            return crudCliente.Retrieve<Cliente>(cliente);
        }

        public void Update(Cliente cliente)
        {
            crudCliente.Update(cliente);
        }

        // revisar ESTO para otras funciones
        public void Delete(string id)
        {
            var cliente = new Cliente();
            cliente.cedula = id;

            crudCliente.Delete(cliente);
        }
    }



}

