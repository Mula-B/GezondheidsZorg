using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezondheidsZorg
{
    class Verzekering
    {
        [Key]
        public int VerzekeringID { get; set; }
        public string VerzekeringNaam { get; set; }
    }
}
