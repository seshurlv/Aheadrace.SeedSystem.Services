using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Facade.Contracts.Users;
using Aheadrace.SeedSystem.Business.Contract.Users;
using Aheadrace.SeedSystem.Business.Users;

namespace Aheadrace.SeedSystem.Facade.Users
{
    public class UserFacade : IUserFacade
    {
        public User GetUserDetailsById(int id)
        {
            return null;
        }

        public User GetUserDetailsByUserName(string userName)
        {
            IUserBLL userBLL = new UserBLL();
            return userBLL.GetUserDetailsByUserName(userName);
        }

        public List<User> GetUsersList()
        {
            IUserBLL userBLL = new UserBLL();
            return userBLL.GetUsersList();
        }

        public List<User> GetUsersByRole(int id)
        {
            IUserBLL userBLL = new UserBLL();
            return userBLL.GetUsersByRole(id);
        }

        public List<Role> GetRoles()
        {
            IUserBLL userBLL = new UserBLL();
            return userBLL.GetRoles();
        }

        public int CreateUser(User user)
        {
            IUserBLL userBLL = new UserBLL();
            return userBLL.CreateUser(user);
        }
    }
}
