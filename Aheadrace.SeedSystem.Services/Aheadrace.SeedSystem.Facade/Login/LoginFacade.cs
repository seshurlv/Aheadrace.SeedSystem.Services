using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Facade.Contracts.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aheadrace.SeedSystem.Business;
using Aheadrace.SeedSystem.Business.Login;
using Aheadrace.SeedSystem.Business.Contract.Login;

namespace Aheadrace.SeedSystem.Facade.Login
{
    public class LoginFacade : ILoginFacade
    {
        public bool VerifyLoginCredentials(string username, string password)
        {
            ILoginBLL logBll = new LoginBLL();
            return logBll.ValidateLoginAndPrepareToken(username, password);
        }
    }
}
