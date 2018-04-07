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
        public string ValidateLoginAndPrepareToken(string username, string password)
        {
            ILoginRepository loginRepo = new LoginRepository();
            if (loginRepo.VerifyLoginCredentials(username, password))
            {
                byte[] time = BitConverter.GetBytes(DateTime.UtcNow.AddHours(24).ToBinary());
                byte[] usrname = Encoding.ASCII.GetBytes(username);
                var token = Convert.ToBase64String(time.Concat(usrname).ToArray());                
                return token;
            }
            else
            {
                return null;
            }
        }
    }
}
