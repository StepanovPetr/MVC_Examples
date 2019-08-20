using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelExample.Models
{

    //Класс Альбом
    public class Album
    {
        //Название Альбома
        public string Name { get; set; }
        //Дата создания 
        public DateTime YearOfBirth { get; set; }
        // Открытый конструктор класса Альбом
        public Album()
        {
            this.Name = "";
            this.YearOfBirth = DateTime.Today;
       
        }
    }
}