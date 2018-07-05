using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezondheidsZorg
{
    public class Medicatie
    {
        [Key]
        public int MedicatieID { get; set; }
        public string MedicatieNaam { get; set; }

        public Klant Klant { get; set; }
        public int KlantID { get; set; }
    }
}
