using CrowDAL = DAL_Crowfunding.Models;
using FundingAPI = Crowfunding.Models;
using DAL_Crowfunding.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crowfunding.Services.Mapper;

namespace Crowfunding.Services
{
    public class UtilisateurService : IUtilisateurRepository<int, FundingAPI.Utilisateur>
    {
        private IUtilisateurRepository<int, CrowDAL.Utilisateur> _repos = new UtilisateurRepository();
        public void Add(FundingAPI.Utilisateur entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void ChangePassword(int id, string motDePasse)
        {
            _repos.ChangePassword(id, motDePasse);
        }

        public int Check(string nomUtilisateur, string motDePasse)
        {
            return _repos.Check(nomUtilisateur, motDePasse);
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Utilisateur> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public FundingAPI.Utilisateur Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, FundingAPI.Utilisateur entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}