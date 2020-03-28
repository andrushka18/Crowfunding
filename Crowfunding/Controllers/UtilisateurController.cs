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
    public class UtilisateurController : ApiController
    {
        private UtilisateurService _service = new UtilisateurService();

        [AcceptVerbs("GET")]
        [Route("Utilisateur")]
        public IEnumerable<Utilisateur> RetrieveAll()
        {
            return _service.Get();
        }

        [AcceptVerbs("POST")]
        [Route("Secure/Utilisateur")]
        public void Register(Utilisateur user)
        {
            _service.Add(user);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Utilisateur")]
        public void ChangePassword(int id, string password)
        {
            _service.ChangePassword(id, password);
        }


        [AcceptVerbs("GET")]
        [Route("Utilisateur/{id}")]
        public Utilisateur Retrieve(int id)
        {
            return _service.Get(id);
        }

        [AcceptVerbs("PUT")]
        [Route("Secure/Utilisateur/{id}")]
        public void ChangeInfo(int id, Utilisateur user)
        {
            _service.Update(id, user);
        }
    }
}