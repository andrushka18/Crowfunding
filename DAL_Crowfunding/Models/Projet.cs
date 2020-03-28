using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Crowfunding.Models
{
    public class Projet
    {
        public int IdProjet { get; set; }
        public string Nom { get; set; }
        public Money PlafondFinance { get; set; }
        private string _NumeroCompte;
        public string NumeroCompte
        {
            get { return _NumeroCompte; }
            set { _NumeroCompte = value; }
        }
        public string UrlVideo { get; set; }

    }
}
