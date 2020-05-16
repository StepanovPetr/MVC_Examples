using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelExample.Models
{
    // Класс музыкант.
    public class Musician
    {
        // Имя музыканта. 
        public string Name { get; set; }
        // Инструмент, на котором играет музыкант.
        public string MusicalInstrument { get; set; }
        // Дата присоединения к группе.
        public DateTime YearOfBirth { get; set; }
        // Открытый конструктор класса музыкант.
        public Musician()
        {
            this.Name = "";
            this.YearOfBirth = DateTime.Today;
            this.MusicalInstrument = "guitar";
        }
    }
}