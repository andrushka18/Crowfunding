using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrowDAL = DAL_Crowfunding.Models;
using FundingAPI = Crowfunding.Models;

namespace Crowfunding.Services.Mapper
{
    public static class CrowFundMap
    {
        public static CrowDAL.Utilisateur ToDAL(this FundingAPI.Utilisateur user)
        {
            return new CrowDAL.Utilisateur
            {
                UtilisateurId = user.Id,
                Nom = user.Nom,
                Prenom = user.Prenom,
                NomUtilisateur = user.NomUtilisateur,
                Password = user.MotDePasse,
                
            };
        }
        public static FundingAPI.Utilisateur ToAPI(this CrowDAL.Utilisateur user)
        {
            return new FundingAPI.Utilisateur
            {
                Id = user.UtilisateurId,
                Nom = user.Nom,
                Prenom = user.Prenom,
                NomUtilisateur = user.NomUtilisateur,
                MotDePasse = user.Password,
            };
        }

        public static CrowDAL.Projet ToDAL(this FundingAPI.Projet projo)
        {
            return new CrowDAL.Projet
            {
                IdProjet = projo.IdProjet,
                Nom = projo.Nom,
                PlafondFinance = projo.PlafondFinance,
                UrlVideo = projo.UrlVideo,
                NumeroCompte = projo.NumeroCompte,

            };
        }
        public static FundingAPI.Projet ToAPI(this CrowDAL.Projet projo)
        {
            return new FundingAPI.Projet
            {
                IdProjet = projo.IdProjet,
                Nom = projo.Nom,
                PlafondFinance = projo.PlafondFinance,
                UrlVideo = projo.UrlVideo,
                NumeroCompte = projo.NumeroCompte,
            };
        }
        public static CrowDAL.Financeur ToDAL(this FundingAPI.Financeur fin)
        {
            return new CrowDAL.Financeur
            {
               
                Montant = fin.Montant,
                Prime = fin.Prime,
             

            };
        }
        public static FundingAPI.Financeur ToAPI(this CrowDAL.Financeur fin)
        {
            return new FundingAPI.Financeur
            {
                Montant = fin.Montant,
                Prime = fin.Prime,

            };
        }
        public static CrowDAL.Valideur ToDAL(this FundingAPI.Valideur Val)
        {
            return new CrowDAL.Valideur
            {

                Status = Val.Status,
                Commentaire = Val.Commentaire,


            };
        }
        public static FundingAPI.Valideur ToAPI(this CrowDAL.Valideur Val)
        {
            return new FundingAPI.Valideur
            {
                Status = Val.Status,
                Commentaire = Val.Commentaire,

            };
        }
        public static CrowDAL.Employe ToDAL(this FundingAPI.Employe emp)
        {
            return new CrowDAL.Employe
            {

                NumeroNational = emp.NumeroNational,
                Date = emp.Date,


            };
        }
        public static FundingAPI.Employe ToAPI(this CrowDAL.Employe emp)
        {
            return new FundingAPI.Employe
            {
                NumeroNational = emp.NumeroNational,
                Date = emp.Date,

            };
        }
        public static CrowDAL.Droit ToDAL(this FundingAPI.Droit role)
        {
            return new CrowDAL.Droit
            {

                IdDroit = role.IdDroit,
                NomDroit = role.NomDroit,


            };
        }
        public static FundingAPI.Droit ToAPI(this CrowDAL.Droit role)
        {
            return new FundingAPI.Droit
            {
                IdDroit = role.IdDroit,
                NomDroit = role.NomDroit,

            };
        }
    }
}