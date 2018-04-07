using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.Facade.Common.Location;
using Aheadrace.SeedSystem.Facade.Contracts.Common.Location;
using Aheadrace.SeedSystem.Services.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aheadrace.SeedSystem.Services.Controllers
{
    [AllowAnonymous]
    [CacheFilter(TimeDuration = 600)]
    public class LocationController : ApiController
    {
        [HttpGet]
        public List<Country> GetCountries()
        {
            ILocationFacade locationFacade = new LocationFacade();
            return locationFacade.GetCountries();
        }

        [HttpGet]
        public List<State> GetStates()
        {
            ILocationFacade locationFacade = new LocationFacade();
            return locationFacade.GetStates();
        }

        [HttpGet]
        public List<District> GetDistricts()
        {
            ILocationFacade locationFacade = new LocationFacade();
            return locationFacade.GetDistricts();
        }

        [HttpGet]
        public List<EPA> GetEPAs()
        {
            ILocationFacade locationFacade = new LocationFacade();
            return locationFacade.GetEPAs();
        }

        [HttpGet]
        public List<Section> GetSections()
        {
            ILocationFacade locationFacade = new LocationFacade();
            return locationFacade.GetSections();
        }

        [HttpGet]
        public List<EPA> GetEPAByDistrictId(int id)
        {
            ILocationFacade locationFacade = new LocationFacade();
            return locationFacade.GetEPAByDistrictId(id);
        }

        [HttpGet]
        public List<Section> GetSectionByEPAId(int id)
        {
            ILocationFacade locationFacade = new LocationFacade();
            return locationFacade.GetSectionByEPAId(id);
        }

        [HttpGet]
        public List<Region> GetRegions(int id)
        {
            ILocationFacade locationFacade = new LocationFacade();
            return locationFacade.GetRegions(id);
        }
    }
}
