using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using ToolBox.JWT;

namespace Crowfunding.FundingAPIPermition
{
    public class FundingAPIPermition : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            actionContext.Request.Headers.TryGetValues("Authorization", out IEnumerable<string> headers);
            string token = headers?.FirstOrDefault(v => v.StartsWith("Bearer "))
            ?.Replace("Bearer ", "");
            JWTService service = new JWTService(
                "Tn!_bTZ&Gt^7LM&X!HxnTT6H",
                "localhost",
                "postman"
            );
            if (token == null || !service.ValidateToken(token))
                base.OnAuthorization(actionContext);
        }
    }
}