using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Crowfunding.Models
{
    public class Palier
    {
        public int IdPalier { get; set; }
        public Money Montant { get; set; }
        public string Prime { get; set; }

    }
}
