using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crowfunding.Models
{
    public class Financeur :Utilisateur
    {
        
        public string Prime { get; set; }
        public Money Montant { get; set; }

    }
}