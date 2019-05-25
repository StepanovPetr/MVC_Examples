using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_2;

namespace MyContext
{
    class MyContentItializer : CreateDatabaseIfNotExists<MyContext.MyContent>

    {


        protected override void Seed(MyContext.MyContent context)
        {

            #region Заполение модели тестовыми данными 
            //Заполние модели тестовыми данными
            Band Elisium = new Band()
            {

                Id = 0,
                Name = "Элизиум",
                City = "Нижний Новгород",
                YearOfBirth = Convert.ToDateTime("01/01/1995"),
                Genre = "Панк-рок, поп-панк, ска-панк, регги",
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

            Band Brutto = new Band()
            {
                Id = 1,
                Name = "Brutto",
                City = "Минск",
                YearOfBirth = Convert.ToDateTime("01/01/2014"),
                Genre = "Панк-рок",
                Albums = new List<Album>()
         {  new Album { Name = "Underdog", YearOfBirth = Convert.ToDateTime("2014/1/1") },
            new Album { Name = "Родны край", YearOfBirth = Convert.ToDateTime("2015/1/1") } ,
            new Album { Name = "Рокі", YearOfBirth = Convert.ToDateTime("2017/1/1") }
          },
                Musicants = new List<Musician>()
                {
                    new Musician {Name="Сергей Михалок (Худрук) ",MusicalInstrument="вокал, музыка, тексты ",YearOfBirth=Convert.ToDateTime("2014/1/1") },
                    new Musician {Name="Виталий Гурков (Огурец) ",MusicalInstrument="вокал  ",YearOfBirth=Convert.ToDateTime("2014/1/1") },
                    new Musician {Name="Сергей Королёв (Бразил)",MusicalInstrument="вокал ",YearOfBirth=Convert.ToDateTime("2014/1/1") },
                    new Musician {Name="Петр Лосевский (Петя Аист)",MusicalInstrument="вокал",YearOfBirth=Convert.ToDateTime("2014/1/1") },
                    new Musician {Name="Павел Третяк (Паша Ланистер)",MusicalInstrument="гитары клавишные",YearOfBirth=Convert.ToDateTime("2014/1/1") },
                    new Musician {Name="Денис Мельник (Лэфт)",MusicalInstrument="вокал гитара",YearOfBirth=Convert.ToDateTime("2014/1/1") },
                    new Musician {Name="Денис Стурченко (Дыня) ",MusicalInstrument="бас-гитара",YearOfBirth=Convert.ToDateTime("2014/1/1") },
                    new Musician {Name="Денис Шуров (Шуруп)",MusicalInstrument="клавишные",YearOfBirth=Convert.ToDateTime("2014/1/1") },
                    new Musician {Name="Владислав Сенкевич (Краб) ",MusicalInstrument="труба, бэк-вокал",YearOfBirth=Convert.ToDateTime("2014/1/1") },
                    new Musician {Name="Иван Галушко (Цыбуля)",MusicalInstrument="тромбон, бэк-вокал",YearOfBirth=Convert.ToDateTime("2014/1/1") }
                }

            };

            Band Kukukryniksy = new Band()
            {
                Id = 2,
                Name = "Кукрыниксы",
                City = "Санкт-Петербург",
                YearOfBirth = Convert.ToDateTime("01/01/1997"),
                Genre = "готик-рок",
                Albums = new List<Album>()
         {  new Album { Name = "Кукрыниксы", YearOfBirth = Convert.ToDateTime("1999/1/1") },
            new Album { Name = "Раскрашенная душа", YearOfBirth = Convert.ToDateTime("2002/1/1") } ,
            new Album { Name = "Столкновение", YearOfBirth = Convert.ToDateTime("2004/1/1") } ,
            new Album { Name = "Фаворит Солнца", YearOfBirth = Convert.ToDateTime("2004/1/1") } ,
            new Album { Name = "Шаман", YearOfBirth = Convert.ToDateTime("2006/1/1") } ,
            new Album { Name = "XXX", YearOfBirth = Convert.ToDateTime("2007/1/1") } ,
            new Album { Name = "Всадники Света", YearOfBirth = Convert.ToDateTime("2010/1/1") } ,
            new Album { Name = "Экклезиаст", YearOfBirth = Convert.ToDateTime("2014/1/1") },
            new Album { Name = "Артист", YearOfBirth = Convert.ToDateTime("2016/1/1") }
          },
                Musicants = new List<Musician>()
                {
                    new Musician {Name="Алексей Горшенёв",MusicalInstrument="вокал, музыка, тексты ",YearOfBirth=Convert.ToDateTime("1997/1/1") },
                    new Musician {Name="Дмитрий Оганян",MusicalInstrument="бас-гитара, бэк-вокал  ",YearOfBirth=Convert.ToDateTime("2000/1/1") },
                    new Musician {Name="Михаил Фомин",MusicalInstrument="ударные, перкуссия ",YearOfBirth=Convert.ToDateTime("2009/1/1") },
                    new Musician {Name="Игорь Воронов",MusicalInstrument=" гитара, клавишные, аранжировки",YearOfBirth=Convert.ToDateTime("2010/1/1") }
                }

            };
            #endregion
            context.Bands.Add(Elisium);
            context.Bands.Add(Brutto);
            context.Bands.Add(Kukukryniksy);
            context.SaveChanges();
            
            //base.Seed(context);
        }
    }
}
