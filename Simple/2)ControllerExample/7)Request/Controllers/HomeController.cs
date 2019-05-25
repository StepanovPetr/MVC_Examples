using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_Request.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        
        public string Request1()
        {
           
            string Data = Request.QueryString["Data"];
            return string.Format("Получение данных из адрессной строки -{0}",Data);
        }

        public string Request2()
        {
           
            string Data = Request.Form["Data"];           
            return string.Format("Получение данных  из тела запроса -{0}", Data);

        }

        //
        // GET: /Data/RouteInformation/

        public ActionResult RouteInformation()
        {
            // Чтение данных, которые передаются с помощью GET запроса, как данные в маршруте.
            ViewBag.Message = RouteData.Values["id"];
            return View("Index");
        }

        //
        // GET: /Data/QueryInformation/

        public ActionResult QueryInformation()
        {
            // Чтение данных, которые передаются в адресной строке.
            ViewBag.Message = Request.QueryString["message"];
            return View("Index");
        }


    }
}