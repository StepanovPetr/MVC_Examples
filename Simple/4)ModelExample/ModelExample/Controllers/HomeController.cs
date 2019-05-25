using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Подлючение пространства имен содержащего классы модели 
using ModelExample.Models;

namespace ModelExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            #region Заполение модели тестовыми данными 
            //Заполние модели тестовыми данными
            Band Elisium = new Band() { Name="Элизиум",City = "Нижний Новгород", YearOfBirth = Convert.ToDateTime("01/01/1995"), Genre = "Панк-рок, поп-панк, ска-панк, регги",
            Albums = new List<Album>()
         {  new Album { Name = "Домой!", YearOfBirth = Convert.ToDateTime("1999/1/1") },
            new Album { Name = "Все острова!", YearOfBirth = Convert.ToDateTime("2002/1/1") } ,
            new Album { Name = "Космос 2003", YearOfBirth = Convert.ToDateTime("2003/1/1") } ,
            new Album { Name = "На окраинах Вселенной", YearOfBirth = Convert.ToDateTime("2005/1/1") } ,
            new Album { Name = "13", YearOfBirth = Convert.ToDateTime("2008/1/1") } ,
            new Album { Name = "Зло умрёт", YearOfBirth = Convert.ToDateTime("2011/1/1") } ,
            new Album { Name = "Снегири и драконы", YearOfBirth = Convert.ToDateTime("2014/1/1") } ,
            new Album { Name = "Яды", YearOfBirth = Convert.ToDateTime("2017/1/1") } 
          },
                Musicants = new List<Musician>()
                {
                    new Musician {Name="Дмитрий «Дракол» Кузнецов",MusicalInstrument="бас-гитара",YearOfBirth=Convert.ToDateTime("1995/1/1") },
                    new Musician {Name="Александр «Пропеллер» Телехов ",MusicalInstrument="вокал, акустическая гитара ",YearOfBirth=Convert.ToDateTime("1997/1/1") },
                    new Musician {Name="Егор Баранов ",MusicalInstrument=" виолончель, клавишные, бэк-вокал",YearOfBirth=Convert.ToDateTime("2008/1/1") },
                    new Musician {Name="Максим Бурмаков",MusicalInstrument="барабаны, перкуссия ",YearOfBirth=Convert.ToDateTime("2015/1/1") },
                    new Musician {Name="Тимофей Осетров",MusicalInstrument="труба",YearOfBirth=Convert.ToDateTime("2015/1/1") },
                    new Musician {Name="Александр Легасов",MusicalInstrument="гитара",YearOfBirth=Convert.ToDateTime("2016/1/1") }
                }

            };
            #endregion
            //Передача данных в модель 
            return View(Elisium);
        }
    }
}