using Crowfunding.Models;
using Crowfunding.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Crowfunding.Controllers
{
    [RoutePrefix("api")]
    public class EmployeController : ApiController
    {
        private EmployeService _service = new EmployeService();

        [AcceptVerbs("GET")]
        [Route("Employé")]
        public IEnumerable<Employe> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("Role/{id}")]
        public Employe Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Role/{id}")]
        public void ChangeInfo(int id, Employe emp)
        {
            _service.Update(id, emp);
        }
    }
}