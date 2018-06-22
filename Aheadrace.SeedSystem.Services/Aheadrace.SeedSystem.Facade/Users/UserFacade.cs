using Aheadrace.SeedSystem.Business.Contracts.Users;
using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Facade.Contracts.Users;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Facade.Users
{
    public class UserFacade : IUserFacade
    {
        private IUserBLL _userBll;

        public UserFacade(IUserBLL userBll)
        {
            _userBll = userBll;
        }

        public User GetUserDetailsById(int id)
        {
            return null;
        }

        public User GetUserDetailsByUserName(string userName)
        {
            return _userBll.GetUserDetailsByUserName(userName);
        }

        public List<User> GetUsersList()
        {
            return _userBll.GetUsersList();
        }

        public List<User> GetUsersByRole(int id)
        {
            return _userBll.GetUsersByRole(id);
        }

        public List<Role> GetRoles()
        {
            return _userBll.GetRoles();
        }

        public int CreateUser(User user)
        {
            return _userBll.CreateUser(user);
        }

        public List<User> GetGrowersWithOpenRegistrations()
        {
            return _userBll.GetGrowersWithOpenRegistrations();
        }

        public int UpdateUser(User user)
        {
            return _userBll.UpdateUser(user);
        }
    }
}
