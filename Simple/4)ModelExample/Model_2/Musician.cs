using System;
using System.ComponentModel.DataAnnotations;

namespace Model_2
{
    // Класс музыкант.
    [Serializable]
    public class Musician
    {
        // Открытый конструктор класса музыкант.
        public Musician()
        {
            Name = "";
            YearOfBirth = DateTime.Today;
            MusicalInstrument = "guitar";
        }

        public int Id { get; set; }

        // Имя музыканта. 
        public string Name { get; set; }

        // Инструмент, на котором играет музыкант.
        public string MusicalInstrument { get; set; }

        // Дата присоединения к группе.
        [DataType(DataType.Date)] 
        public DateTime YearOfBirth { get; set; }

        [Required]
        public virtual Band Band { get; set; }
    }
}
