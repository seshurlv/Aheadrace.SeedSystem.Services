using Aheadrace.SeedSystem.DataContracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Facade.Contracts.Users
{
    public interface IUserFacade
    {
        User GetUserDetailsById(int id);

        User GetUserDetailsByUserName(string userName);

        List<User> GetUsersList();

        List<User> GetUsersByRole(int id);

        List<Role> GetRoles();

        int CreateUser(User user);
    }
}
