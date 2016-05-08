using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppSupportSystem.Areas.Default.Controllers
{
    public class PigmentsController : DefaultController
    {
        //
        // GET: /Default/Pigments/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Пигменты";

            return View();
        }

    }
}
