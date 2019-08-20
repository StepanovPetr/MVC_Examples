using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model_2
{
    //Класс Музыкант
    [Serializable]
    public class Musician
    {
        public int Id { get; set; }
        // Имя Музыканта 
        public string Name { get; set; }
        // Инструмент на котором играет музыкант
        public string MusicalInstrument { get; set; }
        // Дата присоединения к группе
        [DataType(DataType.Date)]
        public DateTime YearOfBirth { get; set; }
        // Открытый конструктор класса Музыкант
        public Musician()
        {
            this.Name = "";
            this.YearOfBirth = DateTime.Today;
            this.MusicalInstrument = "guitar";
        }
        [Required]
        public virtual Band Band { get; set; }
    }
}

