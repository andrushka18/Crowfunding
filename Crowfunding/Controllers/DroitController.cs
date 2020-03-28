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
    public class DroitController:ApiController
    {
        private DroitService _service = new DroitService();

        [AcceptVerbs("GET")]
        [Route("Role")]
        public IEnumerable<Droit> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("GET")]
        [Route("Role/{id}")]
        public Droit Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Role/{id}")]
        public void ChangeInfo(int id, Droit role)
        {
            _service.Update(id, role);
        }

        [AcceptVerbs("PUT", "POST")]
        [Route("Secure/Role/{id}/SetAdmin")]
        public void SetAdmin(int id)
        {
            _service.SetAdmin(id);
        }

        [AcceptVerbs("PUT", "POST")]
        [Route("Secure/Role/{id}/UnsetAdmin")]
        public void UnsetAdmin(int id)
        {
            _service.UnsetAdmin(id);
        }
    }
}