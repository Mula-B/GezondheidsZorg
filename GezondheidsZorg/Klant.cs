﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezondheidsZorg
{
    public class Klant
    {
        [Key]
        public int KlantID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }

        public Arts Arts { get; set; }
        public int ArtsId { get; set; }

        public virtual List<Medicatie> Medicaties { get; set; }


    }
}

