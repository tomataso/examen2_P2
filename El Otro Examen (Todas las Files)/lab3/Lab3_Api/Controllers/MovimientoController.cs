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
    public class MovimientoController : ApiController
    {

        private MovimientoManagement movimientoManager = new MovimientoManagement();




        public IHttpActionResult GetMovimiento()
        {
            return Ok(movimientoManager.RetrieveAll());

        }


        public IHttpActionResult GetMovimiento(int id)
        {
            return Ok(movimientoManager.RetrieveById(id));

        }


        public IHttpActionResult PostMovimiento(Movimiento movimiento)
        {

            movimientoManager.Create(movimiento);

            return Content(HttpStatusCode.Created, movimiento);

        }


        public IHttpActionResult PutMovimiento(Movimiento movimiento)
        {

            movimientoManager.Update(movimiento);

            return Content(HttpStatusCode.OK, movimiento);

        }


        public IHttpActionResult DeleteMovimiento(int id)
        {


            movimientoManager.Delete(id);

            return Ok(HttpStatusCode.OK);

        }



    }
}
