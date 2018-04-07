using Aheadrace.SeedSystem.DataContracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Business.Contract.Login
{
    public interface ILoginBLL
    {
        string ValidateLoginAndPrepareToken(string username, string password);
    }
}
