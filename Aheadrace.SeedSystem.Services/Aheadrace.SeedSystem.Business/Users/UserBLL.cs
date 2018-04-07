using Aheadrace.SeedSystem.Business.Contract.Users;
using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Repository.Contracts.Users;
using Aheadrace.SeedSystem.Repository.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Business.Users
{
    public class UserBLL : IUserBLL
    {
        public User GetUserDetailsById(int id)
        {
            return null;
        }

        public User GetUserDetailsByUserName(string userName)
        {
            IUserRepository userRepo = new UsersRepository();
            return userRepo.GetUserDetailsByUserName(userName);
        }

        public List<User> GetUsersList()
        {
            IUserRepository userRepo = new UsersRepository();
            return userRepo.GetUsersList();
        }

        public List<User> GetUsersByRole(int id)
        {
            IUserRepository userRepo = new UsersRepository();
            return userRepo.GetUsersByRole(id);
        }

        public List<Role> GetRoles()
        {
            IUserRepository userRepo = new UsersRepository();
            return userRepo.GetRoles();
        }

        public int CreateUser(User user)
        {
            IUserRepository userRepo = new UsersRepository();
            return userRepo.CreateUser(user);
        }
    }
}
