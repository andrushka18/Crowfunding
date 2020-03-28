using DAL_Crowfunding.Models;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crowfunding.Models
{
    public class Valideur :Utilisateur
    {
        public string Status { get; set; }
        public string Commentaire { get; set; }
    }
}