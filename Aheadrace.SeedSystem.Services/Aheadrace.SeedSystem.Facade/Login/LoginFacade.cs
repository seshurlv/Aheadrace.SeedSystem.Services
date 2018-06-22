using Aheadrace.SeedSystem.Business.Contracts.Login;
using Aheadrace.SeedSystem.Facade.Contracts.Login;

namespace Aheadrace.SeedSystem.Facade.Login
{
    public class LoginFacade : ILoginFacade
    {
        private ILoginBLL _loginBll;

        public LoginFacade(ILoginBLL loginBll)
        {
            _loginBll = loginBll;
        }

        public bool VerifyLoginCredentials(string username, string password)
        {
            return _loginBll.ValidateLoginAndPrepareToken(username, password);
        }
    }
}
