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
    public class DroitService : IDroitRepository<int, FundingAPI.Droit>
    {
        private IDroitRepository<int, CrowDAL.Droit> _repos = new DroitRepository();

        public void Add(FundingAPI.Droit entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Droit> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public FundingAPI.Droit Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void SetAdmin(int id)
        {
            _repos.SetAdmin(id);
        }

        public void UnsetAdmin(int id)
        {
            _repos.UnsetAdmin(id);
        }

        public void Update(int id, FundingAPI.Droit entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}