using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tarea3.Models;

namespace tarea3.Controllers
{
    public class CalcularController : Controller
    {
        //
        // GET: /Calcular/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calcular datos)
        {
            ViewBag.r = datos.a + datos.b;
            return this.View();
        }


        public ActionResult Sumar(Calcular datos)
        {   ViewBag.r = datos.a + datos.b;
            return this.View();
        }
          
        public ActionResult Restar(Calcular datos) {
            ViewBag.r = datos.a - datos.b;
            return this.View();
        }
          public ActionResult Multiplicar(Calcular datos)
          {   ViewBag.r = datos.a * datos.b;
              return this.View();
          }
          
          public ActionResult Dividir(Calcular datos)
          {   ViewBag.r = datos.c / datos.d;
              return this.View();
          }

         
    }
}
