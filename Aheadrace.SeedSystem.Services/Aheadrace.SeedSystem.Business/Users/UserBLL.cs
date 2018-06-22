using Aheadrace.SeedSystem.Business.Contracts.Users;
using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Repository.Contracts.Users;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Business.Users
{
    public class UserBLL : IUserBLL
    {
        private IUserRepository _userRepo;

        public UserBLL(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User GetUserDetailsById(int id)
        {
            return null;
        }

        public User GetUserDetailsByUserName(string userName)
        {
            return _userRepo.GetUserDetailsByUserName(userName);
        }

        public List<User> GetUsersList()
        {
            return _userRepo.GetUsersList();
        }

        public List<User> GetUsersByRole(int id)
        {
            return _userRepo.GetUsersByRole(id);
        }

        public List<Role> GetRoles()
        {
            return _userRepo.GetRoles();
        }

        public int CreateUser(User user)
        {
            return _userRepo.CreateUser(user);
        }

        public List<User> GetGrowersWithOpenRegistrations()
        {
            return _userRepo.GetGrowersWithOpenRegistrations();
        }

        public int UpdateUser(User user)
        {
            return _userRepo.UpdateUser(user);
        }
    }
}
