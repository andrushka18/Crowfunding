using Google.Type;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money = Google.Type.Money;

namespace DAL_Crowfunding.Models
{
    public class Financeur
    {
        public Money Montant { get; set; }
        public string Prime { get; set; }
        public int UtilisateurId { get; internal set; }
    }
}
