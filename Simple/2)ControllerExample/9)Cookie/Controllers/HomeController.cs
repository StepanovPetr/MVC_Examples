using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _9_Cookie.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Пример добавления cookie.
        public string Method1()
        {
            HttpCookie cookie = new HttpCookie("Key", "Hello word");
            // Добавление  куки с Именем Key и значение Hello word в текущий ответ.
            Response.Cookies.Add(cookie);
       
            return string.Format("Cookie Key ADD to  Response");
        }

        // Пример чтения записи cookie из запроса.
        public string Method2()
        {
            HttpCookie cookie = Request.Cookies["Key"];
            if (cookie != null)
            {
                return string.Format("Value of  Key {0}",cookie.Value);
            }
            else
            {
                return string.Format("Value of  Key Empy");
            }
        }

        // Пример удаления cookie.
        public string Method3()
        {
            HttpCookie cookie = new HttpCookie("Key", "Hello word");

            // пример удаления Cookies.
            cookie.Expires = DateTime.Now.AddDays(-1);
            // Добавление  куки с Именем Key и значение Hello word в текущий ответ.
            Response.Cookies.Add(cookie);

            return string.Format("Cookie Key Delete form  Response");
            
        }
    }
}