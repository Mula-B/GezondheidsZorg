using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezondheidsZorg
{
    class Medicatie
    {
        [Key]
        public string MedicatieID { get; set; }
        public string MedicatieNaam { get; set; }
    }
}
