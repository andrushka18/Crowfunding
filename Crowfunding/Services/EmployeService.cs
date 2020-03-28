using CrowDAL = DAL_Crowfunding.Models;
using FundingAPI = Crowfunding.Models;
using DAL_Crowfunding.Repositories;
using Crowfunding.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crowfunding.Services
{
    public class EmployeService : IEmployeRepository<int, FundingAPI.Employe>
    {
        private IEmployeRepository<int, CrowDAL.Employe> _repos = new EmployeRepository();

        public void Add(FundingAPI.Employe entity)
        {
            _repos.Add(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _repos.Delete(id);
        }

        public IEnumerable<FundingAPI.Employe> Get()
        {
            return _repos.Get().Select(a =>a.ToAPI());
        }

        public FundingAPI.Employe Get(int id)
        {
            return _repos.Get(id).ToAPI();
        }

        public void Update(int id, FundingAPI.Employe entity)
        {
            _repos.Update(id, entity.ToDAL());
        }
    }
}