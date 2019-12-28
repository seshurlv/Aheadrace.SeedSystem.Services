using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.Facade.Contracts.Common.Location;
using System.Collections.Generic;
using System.Web.Http;

namespace Aheadrace.SeedSystem.Services.Controllers
{
    [AllowAnonymous]    
    public class LocationController : ApiController
    {
        private ILocationFacade _locationFacade;

        public LocationController(ILocationFacade locationFacade)
        {
            _locationFacade = locationFacade;
        }

        [HttpGet]
        public List<Country> GetCountries()
        {            
            return _locationFacade.GetCountries();
        }

        [HttpPost]
        public int CreateUpdateCountry(Country country)
        {
            return _locationFacade.CreateUpdateCountry(country);
        }

        [HttpGet]
        public List<State> GetStates()
        {
            return _locationFacade.GetStates();
        }

        [HttpPost]
        public int CreateUpdateState(State state)
        {
            return _locationFacade.CreateUpdateState(state);
        }

        [HttpGet]
        public List<State> GetStatesByCountryId(int countryId)
        {
            return _locationFacade.GetStatesByCountryId(countryId);
        }

        [HttpGet]
        public List<District> GetDistricts()
        {
            return _locationFacade.GetDistricts();
        }

        [HttpPost]
        public int CreateUpdateDistrict(District district)
        {
            return _locationFacade.CreateUpdateDistrict(district);
        }

        [HttpGet]
        public List<EPA> GetEPAs()
        {
            return _locationFacade.GetEPAs();
        }

        [HttpGet]
        public List<Section> GetSections()
        {
            return _locationFacade.GetSections();
        }

        [HttpGet]
        public List<EPA> GetEPAByDistrictId(int id)
        {
            return _locationFacade.GetEPAByDistrictId(id);
        }

        [HttpGet]
        public List<Section> GetSectionByEPAId(int id)
        {
            return _locationFacade.GetSectionByEPAId(id);
        }

        [HttpGet]
        public List<Region> GetRegions(int id)
        {
            return _locationFacade.GetRegions(id);
        }
    }
}
