using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab3_Backend.Entities_POJO;
using Lab3_Backend.Managers;

namespace Lab3_Api.Controllers
{
    public class CreditoController : ApiController
    {

        private CreditoManagment creditoManager = new CreditoManagment();



     
        public IHttpActionResult GetCredito()
        {
            return Ok(creditoManager.RetrieveAll());

        }

        
        public IHttpActionResult GetCredito(int id)
        {
            return Ok(creditoManager.RetrieveById(id));

        }

        
        public IHttpActionResult PostCredito(Credito credito)
        {

            creditoManager.Create(credito);

            return Content(HttpStatusCode.Created, credito);

        }

        
        public IHttpActionResult PutCredito(Credito credito)
        {

            creditoManager.Update(credito);

            return Content(HttpStatusCode.OK, credito);

        }

        
        public IHttpActionResult DeleteCredito(int id)
        {

           
            creditoManager.Delete(id);

            return Ok(HttpStatusCode.OK);

        }


    }
}
