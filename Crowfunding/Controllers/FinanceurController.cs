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
    public class FinanceurController : ApiController
    {
        private FinanceurService _service = new FinanceurService();

        [AcceptVerbs("GET")]
        [Route("Financement")]
        public IEnumerable<Financeur> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("Financement/{id}")]
        public Financeur Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Financement/{id}")]
        public void ChangeInfo(int id, Financeur fin)
        {
            _service.Update(id, fin);
        }
    }
}