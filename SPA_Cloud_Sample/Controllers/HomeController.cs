using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_Cloud_Sample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ReadMe()
        {
            return View();
        }
        public ActionResult Code()
        {         
            return View();
        }
	}
}