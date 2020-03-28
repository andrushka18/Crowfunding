using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crowfunding.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }

    }
}