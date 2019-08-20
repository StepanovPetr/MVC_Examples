using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_Session.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Пример добавления значения в сессию
        public string Method1()
        {
            // Запись значения в сессию.
            Session["Key"] = "Hello word";
            // Задание строка жизнии занчения сессии по умолчанию  (20 мин)
            Session.Timeout = 10;
            return string.Format("Session Key ADD to  Response");
        }
        // Пример получения заначений из сессии
        public string Method2()
        {
            if (Session["Key"] == null)
            {
                return string.Format("Value of  Key Empy");
            }

            string sesionValue = Session["Key"].ToString() ;          
            return string.Format("Value of  Key {0}", sesionValue);                  
        }
    }
}

