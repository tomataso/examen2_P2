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
    public class DireccionController : ApiController
    {


        private DireccionManagement direccionManager = new DireccionManagement();




        public IHttpActionResult GetDireccion()
        {
            return Ok(direccionManager.RetrieveAll());

        }


        public IHttpActionResult GetDireccion(int id)
        {
            return Ok(direccionManager.RetrieveById(id));

        }


        public IHttpActionResult PostDireccion(Direccion direccion)
        {

            direccionManager.Create(direccion);

            return Content(HttpStatusCode.Created, direccion);

        }


        public IHttpActionResult PutDireccion(Direccion direccion)
        {

            direccionManager.Update(direccion);

            return Content(HttpStatusCode.OK, direccion);

        }


        public IHttpActionResult DeleteDireccion(int id)
        {


            direccionManager.Delete(id);

            return Ok(HttpStatusCode.OK);

        }




    }
}
