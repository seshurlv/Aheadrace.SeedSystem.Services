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
    [ServiceAuthorizeAttribute]
    public class HomeController : ApiController
    {
        [HttpGet]
        public List<RegistrationStats> GetRegistrationStats(int year)
        {
            IHomeFacade homeFacade = new HomeFacade();
            return homeFacade.GetRegistrationStats(year);
        }

        [HttpGet]
        public List<CropsRegistered> GetRegistrationPerCrop(int year)
        {
            IHomeFacade homeFacade = new HomeFacade();
            return homeFacade.GetRegistrationPerCrop(year);
        }

        [HttpGet]
        public List<CropsRegistered> GetAreaPerCrop(int year)
        {
            IHomeFacade homeFacade = new HomeFacade();
            return homeFacade.GetAreaPerCrop(year);
        }

        [HttpGet]
        public List<RegistrationStats> GetUserRegistrationsPerMonth(int year)
        {
            IHomeFacade homeFacade = new HomeFacade();
            return homeFacade.GetUserRegistrationsPerMonth(year);
        }

        [HttpGet]
        public List<RegistrationStats> GetUserPerDistrict(int year)
        {
            IHomeFacade homeFacade = new HomeFacade();
            return homeFacade.GetUserPerDistrict(year);
        }

        [HttpGet]
        public List<RegistrationStats> GetInspectedGrowersPerMonth(int userId, int year)
        {
            IHomeFacade homeFacade = new HomeFacade();
            return homeFacade.GetInspectedGrowersPerMonth(userId, year);
        }

        [HttpGet]
        public List<RegistrationStats> GetInspectorStats(int userId, int year)
        {
            IHomeFacade homeFacade = new HomeFacade();
            return homeFacade.GetInspectorStats(userId, year);
        }
    }
}
