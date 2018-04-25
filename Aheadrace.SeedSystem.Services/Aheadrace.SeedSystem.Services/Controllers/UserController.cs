using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Facade.Contracts.Users;
using Aheadrace.SeedSystem.Facade.Users;
using Aheadrace.SeedSystem.Framework.Core;
using Aheadrace.SeedSystem.Services.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aheadrace.SeedSystem.Services.Controllers
{
    
    public class UserController : ApiController
    {
        [HttpGet]
        [ServiceAuthorizeAttribute]
        public User GetUserDetailsById(int id)
        {
            Container.Register<IUserFacade, UserFacade>();
            return null;
        }

        [HttpGet]
        [ServiceAuthorizeAttribute]
        public User GetUserDetailsByUserName(string userName)
        {
            IUserFacade userFacade = new UserFacade();
            return userFacade.GetUserDetailsByUserName(userName);
        }

        [HttpGet]
        [ServiceAuthorizeAttribute]
        public List<User> GetUsersList()
        {
            IUserFacade userFacade = new UserFacade();
            return userFacade.GetUsersList();
        }

        [HttpGet]
        [ServiceAuthorizeAttribute]
        public List<User> GetUsersByRole(int id)
        {
            IUserFacade userFacade = new UserFacade();
            return userFacade.GetUsersByRole(id);
        }

        [HttpGet]
        [ServiceAuthorizeAttribute]
        public List<Role> GetRoles()
        {
            IUserFacade userFacade = new UserFacade();
            return userFacade.GetRoles();
        }

        [HttpPost]
        [AllowAnonymous]
        public int CreateUser(User user)
        {
            IUserFacade userFacade = new UserFacade();
            return userFacade.CreateUser(user);
        }

        [HttpGet]
        [ServiceAuthorizeAttribute]
        public List<User> GetGrowersWithOpenRegistrations()
        {
            IUserFacade userFacade = new UserFacade();
            return userFacade.GetGrowersWithOpenRegistrations();
        }
    }
}
