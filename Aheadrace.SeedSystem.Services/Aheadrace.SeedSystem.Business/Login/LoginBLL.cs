using Aheadrace.SeedSystem.Business.Contracts.Login;
using Aheadrace.SeedSystem.Repository.Contracts.Login;

namespace Aheadrace.SeedSystem.Business.Login
{
    public class LoginBLL : ILoginBLL
    {
        private ILoginRepository _loginRepo;

        public LoginBLL(ILoginRepository loginRepo)
        {
            _loginRepo = loginRepo;
        }

        public bool ValidateLoginAndPrepareToken(string username, string password)
        {
            return _loginRepo.VerifyLoginCredentials(username, password);
        }
    }
}
