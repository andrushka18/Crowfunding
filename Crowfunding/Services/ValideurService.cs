using CrowDAL = DAL_Crowfunding.Models;
using FundingAPI = Crowfunding.Models;
using DAL_Crowfunding.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crowfunding.Models;
using Crowfunding.Services.Mapper;

namespace Crowfunding.Services
{
    public class ValideurService : IValideurRepository<int, FundingAPI.Valideur>
    {
        private IValideurRepository<int, CrowDAL.Valideur> _repos = new ValideurRepository();

        public void Add(Valideur entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<Valideur> Get()
        {
            return _repos.Get().Select(a => a.ToAPI());
        }

        public Valideur Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, Valideur entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}