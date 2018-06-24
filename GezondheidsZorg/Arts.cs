using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezondheidsZorg
{
    public class Arts
    {
        [Key]
        public int ArtsID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }
        public DateTime Einddatum { get; set; }

        public virtual List<Klant> Klanten { get; set; }
        
    }
}
