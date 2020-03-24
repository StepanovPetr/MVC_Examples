using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_HttpStatusCodeResult.Controllers
{
    public class HttpStatusCodeController : Controller
    {
        // GET: HttpStatusCode.
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Method1()
        {
            // вывод 404 ошибки NotFound.
            return HttpNotFound();
        }

        public ActionResult Method2()
        {
            // вывод 500. 
            return new HttpStatusCodeResult(500, "Internal Server Error");
        }
         
    }
}