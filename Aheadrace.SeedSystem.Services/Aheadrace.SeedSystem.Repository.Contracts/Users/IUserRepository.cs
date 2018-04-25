using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aheadrace.SeedSystem.DataContracts.Users;

namespace Aheadrace.SeedSystem.Repository.Contracts.Users
{
    public interface IUserRepository
    {
        User GetUserDetailsById(int id);

        User GetUserDetailsByUserName(string userName);

        List<User> GetUsersList();

        int CreateUser(User user);

        List<User> GetUsersByRole(int id);

        List<Role> GetRoles();

        List<User> GetGrowersWithOpenRegistrations();
    }
}
