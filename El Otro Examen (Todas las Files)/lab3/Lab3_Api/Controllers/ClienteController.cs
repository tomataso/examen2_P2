using Lab3_Backend.Entities_POJO;
using Lab3_Backend.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab3_Api.Controllers
{
    public class ClienteController : ApiController
    {

        private ClienteManagment clienteManager = new ClienteManagment();



       
        public IHttpActionResult GetCliente()
        {
            return Ok(clienteManager.RetrieveAll());

        }

    
        public IHttpActionResult GetCliente(string id)
        {
            return Ok(clienteManager.RetrieveById(id));

        }

       
        public IHttpActionResult Post(Cliente cliente)
        {

            clienteManager.Create(cliente);

            return Content(HttpStatusCode.Created, cliente);

        }

        
        public IHttpActionResult PutCliente(Cliente cliente)
        {

            clienteManager.Update(cliente);

            return Content(HttpStatusCode.OK, cliente);

        }

        
        public IHttpActionResult DeleteCliente(string id)
        {

           
            clienteManager.Delete(id);

            return Ok(HttpStatusCode.OK);

        }


        // REVISAR DESPUÉS

        /*
        public IHttpActionResult PruebaPost(Cliente cliente)
        {

            var clienteManager = new ClienteManagment();


            try
            {
                clienteManager.Create(cliente);
                return Ok();
            }
            catch (Exception)
            {
                return pene

            }


            return Ok();
        }
*/



    }

}

