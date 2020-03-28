using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crowfunding.Models
{
    public class Employe:Utilisateur
    {
        public int NumeroNational { get; set; }
        public DateTime Date { get; set; }
       
    }
}