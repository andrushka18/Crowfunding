using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Crowfunding.Models
{
    public class Valideur
    {
        public string Status { get; set; }
        public string Commentaire { get; set; }
        public int UtilisateurId { get; internal set; }
    }
}
