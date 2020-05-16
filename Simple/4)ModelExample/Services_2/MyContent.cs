using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model_2;
using MyContext;

namespace Services_2
{
   public class DbServises
    {

        private MyContent db { get; set; }

        public DbServises()
        {
            db = new MyContent();
        }

        public async Task<DbSet<Band>> SelectAllAsinc()
        {
           return await Task<DbSet<Band>>.Run(() => SelectAll());
        }

        public DbSet<Band> SelectAll()
        {
            return db.Bands;
        }

        public Band FindElem(int ID)
        {
            return db.Bands.FirstOrDefault(s => s.Id == ID);
        }

        public bool EditElem(Band band)
        {
            db.Bands.Attach(band);
            db.SaveChanges();
            return true;
        }

        public bool DeleteElem(int id)
        {
            db.Bands.Remove(this.FindElem(id));
            db.SaveChanges();
            return true;
        }

        public bool AddElem(Band band)
        {
            db.Bands.Add(band);
            db.SaveChanges();
            return true;
        }
    }
}
