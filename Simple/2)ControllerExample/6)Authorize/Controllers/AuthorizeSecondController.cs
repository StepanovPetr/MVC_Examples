using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_Authorize.Controllers
{

    [Authorize]
    public class AuthorizeSecondController : Controller
    {
        [AllowAnonymous]
        public string Authorize1()
        {
            // Получение значения аутеннтификации пользователя. 
            bool isAuthenticated = User.Identity.IsAuthenticated;
            // Проверка на то, что пользователь прошел Аутентификацию.
            if (isAuthenticated)
            {
                // Получение имени пользователя, от которого пришел запрос. 
                string userName = User.Identity.Name;
                // Получение типа AuthenticationType.
                string authenticationType = User.Identity.AuthenticationType;

                return $"Имя пользователя - {userName}," +
                       $" тип аутентификации {authenticationType}";
            }
            else
            {
                return "Пользователь анонимен";
            }
        }
    }
}
