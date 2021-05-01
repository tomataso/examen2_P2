using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Lab4_Webapp.Controllers
{
  
    public class HomeController : Controller
    {

        static HttpClient client = new HttpClient();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Vistas hacia formularios.
        public ActionResult vFormRegistro_Cliente()
        {
            return View();
        }
    }

   
}