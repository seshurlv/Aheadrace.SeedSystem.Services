using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Aheadrace.SeedSystem.Services.Filters
{
    public class ServiceAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.GetValues("ServiceAccessToken") != null)
            {
                string strServiceToken = Convert.ToString(actionContext.Request.Headers.GetValues("ServiceAccessToken").FirstOrDefault());
                if (!ValidateServiceToken(strServiceToken))
                {
                    HttpContext.Current.Response.AddHeader("authenticationToken", strServiceToken);
                    HttpContext.Current.Response.AddHeader("AuthenticationStatus", "NotAuthorized");
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden);
                    return false;
                }

                HttpContext.Current.Response.AddHeader("authenticationToken", strServiceToken);
                HttpContext.Current.Response.AddHeader("AuthenticationStatus", "Authorized");
                return true;
            }
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.ExpectationFailed);
            actionContext.Response.ReasonPhrase = "Please provide valid inputs";
            return false;
        }

        public bool ValidateServiceToken(string strToken)
        {
            string strStoredToken = string.Empty;//read token from DB for this user
            byte[] data = Convert.FromBase64String(strToken);
            DateTime expiryDateTime = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
            return expiryDateTime > DateTime.UtcNow;
        }
    }
}