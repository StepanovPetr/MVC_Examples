using System.Data.Entity;
using Model_2;

namespace MyContext
{
    public class MyContent : DbContext
    {
        public MyContent()
            : base(@"Band")
        {
            Database.SetInitializer(new MyContentItializer());
        }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Musician> Musicians { get; set; }
    }
}