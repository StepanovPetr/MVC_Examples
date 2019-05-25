using System.Web.Mvc;

namespace ControllerExample.Controllers
{
    public class MyFirstController : Controller
    {
      
        // По умолчанию методы вызываются по GET запросу
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

        // нужно выполнить POST запрос
        [HttpPost]
        public string Method3()
        {
            return "Method3";
        }
  
    }
}

