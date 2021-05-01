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
    public class CuentaController : ApiController
    {
        private CuentaManagment cuentaManager = new CuentaManagment();




        public IHttpActionResult GetCuenta()
        {
            return Ok(cuentaManager.RetrieveAll());

        }


        public IHttpActionResult GetCuenta(int id)
        {
            return Ok(cuentaManager.RetrieveById(id));

        }


        public IHttpActionResult PostCuenta(Cuenta cuenta)
        {

            cuentaManager.Create(cuenta);

            return Content(HttpStatusCode.Created, cuenta);

        }


        public IHttpActionResult PutCuenta(Cuenta cuenta)
        {

            cuentaManager.Update(cuenta);

            return Content(HttpStatusCode.OK, cuenta);

        }


        public IHttpActionResult DeleteCuenta(int id)
        {


            cuentaManager.Delete(id);

            return Ok(HttpStatusCode.OK);

        }



    }
}
