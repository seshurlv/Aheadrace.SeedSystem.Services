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

    [JWTAuthentication]
    public class UserController : ApiController
    {
        private IUserFacade _userFacade;

        public UserController(IUserFacade userFacade)
        {
            _userFacade = userFacade;
        }

        [HttpGet]        
        public User GetUserDetailsById(int id)
        {
            //yet to implement
            return null;
        }

        [HttpGet]                
        public User GetUserDetailsByUserName(string userName)
        {
            return _userFacade.GetUserDetailsByUserName(userName);
        }

        [HttpGet]        
        public List<User> GetUsersList()
        {
            return _userFacade.GetUsersList();
        }

        [HttpGet]
        public List<User> GetUsersByRole(int id)
        {
            return _userFacade.GetUsersByRole(id);
        }

        [HttpGet]        
        public List<Role> GetRoles()
        {
            return _userFacade.GetRoles();
        }

        [HttpPost]
        [AllowAnonymous]
        public int CreateUser(User user)
        {
            return _userFacade.CreateUser(user);
        }

        [HttpGet]        
        public List<User> GetGrowersWithOpenRegistrations()
        {
            return _userFacade.GetGrowersWithOpenRegistrations();
        }

        [HttpPost]        
        public int UpdateUser(User user)
        {
            return _userFacade.UpdateUser(user);
        }
    }
}
