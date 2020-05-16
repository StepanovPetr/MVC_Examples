using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _9_Cookie.Controllers
{
    public class HomeController : Controller
    {
        // Пример добавления cookie.
        public string Method1()
        {
            HttpCookie cookie = new HttpCookie("Key", "Hello word");
            // Добавление cookie с именем Key и значением Hello word в текущий ответ.
            Response.Cookies.Add(cookie);
       
            return "Cookie Key add to Response";
        }

        // Пример чтения записи cookie из запроса.
        public string Method2()
        {
            HttpCookie cookie = Request.Cookies["Key"];
            if (cookie != null)
            {
                return $"Value of  Key {cookie.Value}";
            }
            else
            {
                return "Value of  Key Empy";
            }
        }

        // Пример удаления cookie.
        public string Method3()
        {
            HttpCookie cookie = new HttpCookie("Key", "Hello word");

            // Пример удаления сookie.
            cookie.Expires = DateTime.Now.AddDays(-1);
            // Добавление  сookie с именем Key и значением Hello word в текущий ответ.
            Response.Cookies.Add(cookie);

            return "Cookie Key Delete form  Response";
        }
    }
}