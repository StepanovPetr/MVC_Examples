using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_Authorize.Controllers
{

    [Authorize(Roles = "Administrator,IIS_IUSRS")]
    public class AuthorizeThirdController : Controller
    {
        // GET: AuthorizeThird
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public string Authorize1()
        {

            //Получени занчения об Аутеннтификации пользователя 
            bool isAuthenticated = User.Identity.IsAuthenticated;
            //Проверка на то что пользователь прошел Аутеннтификацию
            if (isAuthenticated)
            {

                //Получени имени пользователя от которого пришел запрос 
                string userName = User.Identity.Name;
                //Получени типа  AuthenticationType
                string authenticationType = User.Identity.AuthenticationType;

                return string.Format("Имя пользователя  - {0} , тип Аутентификации  {1}", userName, authenticationType);
            }
            else
            {

                return string.Format("Пользователь Анонимен");
            }

        }


    }
}