using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelExample.Models
{
    // Класс Группа.
    public class Band
    {
        // Название группы.
        public string Name { get; set; }
        // Жанр в котором играет группа.
        public string Genre { get; set; }
        // Родной город.
        public string City { get; set; }
        // Дата создания группы.
        public DateTime YearOfBirth { get; set; }
        // Коллекция объектов класса музыкант (Состав группы).
        public List<Musician> Musicants { get; set; }
        // Коллекция объектов класса альбом (Выпущенные альбомы).
        public List<Album> Albums { get; set; }
        // Открытый конструктор класса группа.
        public Band()
        {
        }
    }
}
