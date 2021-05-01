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
    public class PagoController : ApiController
    {

        private PagoManagement pagoManager = new PagoManagement();




        public IHttpActionResult GetPago()
        {
            return Ok(pagoManager.RetrieveAll());

        }


        public IHttpActionResult GetPago(int id)
        {
            return Ok(pagoManager.RetrieveById(id));

        }


        public IHttpActionResult PostPago(Pago pago)
        {

            pagoManager.Create(pago);

            return Content(HttpStatusCode.Created, pago);

        }


        public IHttpActionResult PutPago(Pago pago)
        {

            pagoManager.Update(pago);

            return Content(HttpStatusCode.OK, pago);

        }


        public IHttpActionResult DeletePago(int id)
        {


            pagoManager.Delete(id);

            return Ok(HttpStatusCode.OK);

        }




    }
}
