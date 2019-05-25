using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _8_ModelBinding.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public People()
        {
            Id = 0;
            Name = "";
        }

    }
}