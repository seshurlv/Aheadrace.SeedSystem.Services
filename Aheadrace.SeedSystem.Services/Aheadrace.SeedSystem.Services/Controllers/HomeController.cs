using Aheadrace.SeedSystem.DataContracts.Home;
using Aheadrace.SeedSystem.Facade.Contracts.Home;
using Aheadrace.SeedSystem.Facade.Home;
using Aheadrace.SeedSystem.Services.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
    
namespace Aheadrace.SeedSystem.Services.Controllers
{
    [JWTAuthentication]
    public class HomeController : ApiController
    {
        private IHomeFacade _homeFacade;

        public HomeController(IHomeFacade homeFacade)
        {
            _homeFacade = homeFacade;
        }

        [HttpGet]
        public List<RegistrationStats> GetRegistrationStats(int year)
        {
            return _homeFacade.GetRegistrationStats(year);
        }

        [HttpGet]
        public List<CropsRegistered> GetRegistrationPerCrop(int year)
        {
            return _homeFacade.GetRegistrationPerCrop(year);
        }

        [HttpGet]
        public List<CropsRegistered> GetAreaPerCrop(int year, int userId, int role)
        {
            return _homeFacade.GetAreaPerCrop(year, userId, role);
        }

        [HttpGet]
        public List<RegistrationStats> GetUserRegistrationsPerMonth(int year)
        {
            return _homeFacade.GetUserRegistrationsPerMonth(year);
        }

        [HttpGet]
        public List<RegistrationStats> GetUserPerDistrict(int year)
        {
            return _homeFacade.GetUserPerDistrict(year);
        }

        [HttpGet]
        public List<RegistrationStats> GetInspectedGrowersPerMonth(int userId, int year)
        {
            return _homeFacade.GetInspectedGrowersPerMonth(userId, year);
        }

        [HttpGet]
        public List<RegistrationStats> GetInspectorStats(int userId, int year, int role)
        {
            return _homeFacade.GetInspectorStats(userId, year, role);
        }
    }
}
