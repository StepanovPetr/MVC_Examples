using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model_2;

namespace MyContext
{
    public class MyContent : DbContext
    {

        public MyContent()
            : base(@"Band")
        {
            Database.SetInitializer<MyContent>(new MyContentItializer());
        }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Musician> Musicians { get; set; }

     
    }
}
