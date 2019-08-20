using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelExample.Models
{

    // Класс Группа
    public class Band
    {
        //Название  Группы
        public string Name { get; set; }
        //Жанр в котором играет Группа
        public string Genre { get; set; }
        //Родной город
        public string City { get; set; }
        //Дата создания Группы
        public DateTime YearOfBirth { get; set; }
        //Коллекция обьктов класса Музыкант (Состав Группы)
        public List<Musician> Musicants { get; set; }
        //Коллекция обьктов класса Альбом (Выпущенные Альбомы )
        public List<Album> Albums { get; set; }
        // Открытый конструктор класса Группа
        public Band()
        {
        }
    }
}