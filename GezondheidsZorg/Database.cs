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
        public DbSet<Klant> klant { get; set; }
        public DbSet<Arts> arts { get; set; }
        public DbSet<Medicatie> medicatie { get; set; }
        public DbSet<Verzekering> verzekering { get; set; }
    }
}
