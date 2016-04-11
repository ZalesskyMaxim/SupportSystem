using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppSupportSystem.Controllers;

namespace WebAppSupportSystem.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Admin/Home/
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminMenu()
        {
            return View();
        }

    }
}
