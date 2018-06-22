using Aheadrace.SeedSystem.DataContracts.Users;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Business.Contracts.Users
{
    public interface IUserBLL
    {
        User GetUserDetailsById(int id);

        User GetUserDetailsByUserName(string userName);

        List<User> GetUsersList();

        List<User> GetUsersByRole(int id);

        List<Role> GetRoles();

        int CreateUser(User user);

        List<User> GetGrowersWithOpenRegistrations();

        int UpdateUser(User user);
    }
}
