using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Crowfunding.Models
{
    public class Employe
    {
        public int NumeroNational { get; set; }
        public DateTime Date { get; set; }
        public int UtilisateurId { get; internal set; }
    }
}
