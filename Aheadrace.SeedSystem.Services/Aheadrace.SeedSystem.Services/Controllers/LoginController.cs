using Aheadrace.SeedSystem.Facade.Contracts.Login;
using Aheadrace.SeedSystem.Facade.Login;
using Aheadrace.SeedSystem.Services.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aheadrace.SeedSystem.Services.Controllers
{
    [AllowAnonymous]
    public class LoginController : ApiController
    {
        public LoginController()
        {

        }

        [HttpGet]
        public string GetServiceToken(string username, string password)
        {
            return PrepareToken(username, password);
        }

        private string PrepareToken(string username, string password)
        {
            //var userName = Request.Headers.Contains("username") ? Request.Headers.GetValues("uname").FirstOrDefault() : string.Empty;
            //var password = Request.Headers.Contains("pword") ? Request.Headers.GetValues("pword").FirstOrDefault() : string.Empty;
            ILoginFacade log = new LoginFacade();
            return log.VerifyLoginCredentials(username, password);
        }
    }
}
