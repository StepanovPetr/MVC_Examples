using System.Web.Mvc;

namespace ControllerExample.Controllers
{
    public class MyFirstController : Controller
    {  
        // Метод доступен по любому HTTP глаголу
        public string Index()
        {
            return "Hello World";
        }

        // Нужно выполнить GET запрос
        [HttpGet] 
        public string Method1()
        {
            return "Method1";
        }

        // Нужно выполнить GET запрос
        [HttpGet] 
        public string Method2()
        {
            return "Method2";
        }

        // Нужно выполнить POST запрос
        [HttpPost]
        public string Method3()
        {
            return "Method3";
        } 
    }
}

