using System.Web.Mvc;

namespace _10_Session.Controllers
{
    public class HomeController : Controller
    {
        // Пример добавления значения в сессию.
        public string Method1()
        {
            // Запись значения в сессию.
            Session["Key"] = "Hello word";
            // Задание строка жизнии значение сессии по умолчанию  (20 мин).
            Session.Timeout = 10;
            return "Session Key ADD to  Response";
        }

        // Пример получения значений из сессии.
        public string Method2()
        {
            if (Session["Key"] == null)
            {
                return "Value of  Key Empy";
            }

            var sesionValue = Session["Key"].ToString();
            return $"Value of  Key {sesionValue}";                  
        }
    }
}

