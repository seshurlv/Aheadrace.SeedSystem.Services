using Aheadrace.SeedSystem.Business.Contracts.Common.Location;
using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.Facade.Contracts.Common.Location;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Facade.Common.Location
{
    public class LocationFacade : ILocationFacade
    {
        private ILocationBLL _locationBll;

        public LocationFacade(ILocationBLL locationBll)
        {
            _locationBll = locationBll;
        }

        public List<Country> GetCountries()
        {
            return _locationBll.GetCountries();
        }

        public int CreateUpdateCountry(Country country)
        {
            return _locationBll.CreateUpdateCountry(country);
        }

        public List<State> GetStates()
        {
            return _locationBll.GetStates();
        }

        public int CreateUpdateState(State state)
        {
            return _locationBll.CreateUpdateState(state);
        }

        public List<District> GetDistricts()
        {
            return _locationBll.GetDistricts();
        }

        public int CreateUpdateDistrict(District district)
        {
            return _locationBll.CreateUpdateDistrict(district);
        }

        public List<State> GetStatesByCountryId(int countryId)
        {
            return _locationBll.GetStatesByCountryId(countryId);
        }

        public List<EPA> GetEPAs()
        {
            return _locationBll.GetEPAs();
        }

        public List<Section> GetSections()
        {
            return _locationBll.GetSections();
        }

        public List<EPA> GetEPAByDistrictId(int id)
        {
            return _locationBll.GetEPAByDistrictId(id);
        }

        public List<Section> GetSectionByEPAId(int id)
        {
            return _locationBll.GetSectionByEPAId(id);
        }

        public List<Region> GetRegions(int id)
        {
            return _locationBll.GetRegions(id);
        }
    }
}
