using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model_2
{

    // Класс Группа
    [Serializable]
    public class Band
    {
        // ID группы
        public int Id { get; set; }
        //Название  Группы
        [DisplayName("Название  Группы")]
        [Required(ErrorMessage = "Название  Группы не должно быть пустым")]
        public string Name { get; set; }
        //Жанр в котором играет Группа
        [DisplayName("Жанр Группы")]
        [Required(ErrorMessage = "Жанр Группы не должен быть пустым")]
        public string Genre { get; set; }
        //Родной город
        [DisplayName("Родной город")]
        [Required(ErrorMessage = "Город  не  должен быть пустым")]
        public string City { get; set; }
        //Дата создания Группы
        [DisplayName("Дата создания")]
        [Required(ErrorMessage = "Дата  создания  не должна быть пустой")]
        [DataType(DataType.Date)]
        public DateTime YearOfBirth { get; set; }
        //Коллекция обьктов класса Музыкант (Состав Группы)
        //public List<Musician> Musicants { get; set; }
        public virtual ICollection<Musician> Musicants { get; set; }
        //Коллекция обьктов класса Альбом (Выпущенные Альбомы )
        //public List<Album> Albums { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        // Открытый конструктор класса Группа
        public Band()
        {

        }

    }
}