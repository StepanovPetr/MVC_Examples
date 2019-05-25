using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_Authorize.Controllers
{
    public class AuthorizeFirstController : Controller
    {
        // GET: AuthorizeFirst
        public ActionResult Index()
        {
            return View();
        }

        [Authorize] 
        public string Authorize1()
        {

            //Получени имени пользователя от которого пришел запрос 
            string userName = User.Identity.Name;
            //Получени типа  AuthenticationType
            string authenticationType = User.Identity.AuthenticationType;
            return string.Format("Имя пользователя  - {0} , тип Аутентификации  {1}", userName, authenticationType);
        }

    }
}