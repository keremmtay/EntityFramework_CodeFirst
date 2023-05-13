using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class Context : DbContext
    {
        public Context() : base("Server=ASUS;Database=DbEfCodeFirst;Integrated Security = true")
        {

        }

        //public Context() : base("name=ilkEfProjem")
        //{

        //}
        public DbSet<Urun> Urunler { get; set; }
    }
}
