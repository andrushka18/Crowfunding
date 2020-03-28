using Crowfunding.FundingAPIPermition;
using Crowfunding.Models;
using Crowfunding.Services;
using System.Web.Http;
using ToolBox.JWT;

namespace Crowfunding.Controllers
{
    [RoutePrefix("api")]

    public class SecurityController : ApiController
    {
        [Route("login")]
        [HttpPost]
        public IHttpActionResult Login(CompteUtilisateur model)
        {
            UtilisateurService us = new UtilisateurService();
            int id = us.Check(model.NomUtilisateur, model.Password);
            if (id == 0)
            {
                return Unauthorized();
            }
            else
            {
                Utilisateur u = us.Get(id);
                JWTService service = new JWTService(
                     "Tn!_bTZ&Gt^7LM&X!HxnTT6H",
                     "localhost",
                     "postman"
                 );
                return Ok(service.Encode(u));
            }
        }

    }
}