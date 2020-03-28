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
    public class ProjetController : ApiController
    {
        private ProjetService _service = new ProjetService();

        [AcceptVerbs("GET")]
        [Route("Projet")]
        public IEnumerable<Projet> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("Projet/{id}")]
        public Projet Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Role/{id}")]
        public void ChangeInfo(int id, Projet projo)
        {
            _service.Update(id, projo);
        }
    }
}