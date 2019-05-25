using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Redirect.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult Index()
        {
            return View();
        }

        // Нужно выполнить GET запрос
        [HttpGet] 
        public string Method1()
        {
            return "Method1";
        }

    }
}