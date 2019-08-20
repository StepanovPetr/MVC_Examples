using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_UserIdentity.Controllers
{
    public class HomeController : Controller
    {      
        public string Index()
        {
            //Получение занчения об аутеннтификации пользователя 
            bool isAuthenticated = User.Identity.IsAuthenticated;
            //Проверка на то, что пользователь прошел аутеннтификацию
            if (isAuthenticated)
            {
                //Получение имени пользователя от которого пришел запрос 
                string userName = User.Identity.Name;
                //Получение типа  AuthenticationType
                string authenticationType = User.Identity.AuthenticationType; 

                return string.Format("Имя пользователя - {0}, тип Аутентификации {1}",
                    userName, authenticationType);
            }
            else
            {
                return string.Format("Пользователь Анонимен");
            }    
        }      
    }
}

