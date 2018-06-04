using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Repository.Contracts.Login;
using Aheadrace.SeedSystem.Repository.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aheadrace.SeedSystem.Framework;
using Aheadrace.SeedSystem.Business.Contract.Login;

namespace Aheadrace.SeedSystem.Business.Login
{
    public class LoginBLL : ILoginBLL
    {
        public bool ValidateLoginAndPrepareToken(string username, string password)
        {
            ILoginRepository loginRepo = new LoginRepository();
            return loginRepo.VerifyLoginCredentials(username, password);
        }
    }
}
