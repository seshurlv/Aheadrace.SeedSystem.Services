using Aheadrace.SeedSystem.DataContracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Repository.Contracts.Login
{
    public interface ILoginRepository
    {
        bool VerifyLoginCredentials(string username, string password);
    }
}
