using Aheadrace.SeedSystem.Facade.Contracts.Login;
using Aheadrace.SeedSystem.Services.Filters;
using System.Web.Http;

namespace Aheadrace.SeedSystem.Services.Controllers
{
    [AllowAnonymous]
    public class LoginController : ApiController
    {
        private ILoginFacade _loginFacade;

        public LoginController(ILoginFacade loginFacade)
        {
            _loginFacade = loginFacade;
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
            if(_loginFacade.VerifyLoginCredentials(username, password))
            {
                return JWTAuthenticationAttribute.GenerateToken(username);
            }
            return "";
        }

       
    }
}
