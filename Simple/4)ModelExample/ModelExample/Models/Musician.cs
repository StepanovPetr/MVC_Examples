using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelExample.Models
{

    //Класс Музыкант
    public class Musician
    {
        // Имя Музыканта 
        public string Name { get; set; }
        // Инструмент на котором играет музыкант
        public string MusicalInstrument { get; set; }
        // Дата присоединения к группе
        public DateTime YearOfBirth { get; set; }
        // Открытый конструктор класса Музыкант
        public Musician()
        {
            this.Name = "";
            this.YearOfBirth = DateTime.Today;
            this.MusicalInstrument = "guitar";
        }
    }
}