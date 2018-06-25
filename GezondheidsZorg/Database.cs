using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezondheidsZorg
{
    class DatabaseContext : DbContext
    {
        public DbSet<Klant> klanten { get; set; }
        public DbSet<Arts> artsen { get; set; }
        public DbSet<Medicatie> medicaties { get; set; }
        public DbSet<Verzekering> verzekeringen { get; set; }
    }
}
