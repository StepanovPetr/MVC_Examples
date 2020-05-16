using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_Authorize.Controllers
{
    public class AuthorizeFirstController : Controller
    {
        [Authorize] 
        public string Authorize1()
        {
            //Получение имени пользователя, от которого пришел запрос 
            string userName = User.Identity.Name;
            //Получение типа  AuthenticationType
            string authenticationType = User.Identity.AuthenticationType;
            return $"Имя пользователя - {userName}, " +
                   $"тип Аутентификации {authenticationType}";
        }
    }
}
