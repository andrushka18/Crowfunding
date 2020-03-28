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
    public class ProjetService : IProjetRepository<int, FundingAPI.Projet>
    {
        private IProjetRepository<int, CrowDAL.Projet> _repos = new ProjetRepository();
        public void Add(FundingAPI.Projet entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Projet> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public FundingAPI.Projet Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, FundingAPI.Projet entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}