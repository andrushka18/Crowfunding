using CrowDAL = DAL_Crowfunding.Models;
using FundingAPI = Crowfunding.Models;
using DAL_Crowfunding.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crowfunding.Services.Mapper;
using Crowfunding.Models;

namespace Crowfunding.Services
{
    public class FinanceurService : IFinanceurRepository<int, FundingAPI.Financeur>
    {
        private IFinanceurRepository<int, CrowDAL.Financeur> _repos = new FinanceurRepository();

        public void Add(Financeur entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<Financeur> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public Financeur Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, Financeur entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }  
}