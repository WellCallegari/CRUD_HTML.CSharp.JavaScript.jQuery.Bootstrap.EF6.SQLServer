using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Cadastre aqui seu cliente:";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Desenvolvimento de CRUD simples";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "... e Localização";

            return View();
        }
    }
}