using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_Request.Controllers
{
    public class HomeController : Controller
    {
        public string Request1()
        {
            string data = Request.QueryString["Data"];
            return $"Получение данных из адресной строки -{data}";
        }

        public string Request2()
        {
            string data = Request.Form["Data"];           
            return $"Получение данных из тела запроса -{data}";
        }

        public ActionResult RouteInformation()
        {
            // Чтение данных, которые передаются с помощью GET запроса, как данные в маршруте.
            ViewBag.Message = RouteData.Values["id"];
            return View("Index");
        }

        public ActionResult QueryInformation()
        {
            // Чтение данных, которые передаются в адресной строке.
            ViewBag.Message = Request.QueryString["message"];
            return View("Index");
        }
    }
}
