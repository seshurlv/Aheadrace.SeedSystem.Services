using Aheadrace.SeedSystem.Business.Contracts.Common.Location;
using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.Repository.Contracts.Common.Location;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Business.Common.Location
{
    public class LocationBLL : ILocationBLL
    {
        private ILocationRepository _locationRepo;

        public LocationBLL(ILocationRepository locationRepo)
        {
            _locationRepo = locationRepo;
        }

        public List<Country> GetCountries()
        {
            return _locationRepo.GetCountries();
        }

        public int CreateUpdateCountry(Country country)
        {
            return _locationRepo.CreateUpdateCountry(country);
        }

        public List<State> GetStates()
        {
            return _locationRepo.GetStates();
        }

        public int CreateUpdateState(State state)
        {
            return _locationRepo.CreateUpdateState(state);
        }


        public List<State> GetStatesByCountryId(int countryId)
        {
            return _locationRepo.GetStatesByCountryId(countryId);
        }

        public List<District> GetDistricts()
        {
            return _locationRepo.GetDistricts();
        }

        public int CreateUpdateDistrict(District district)
        {
            return _locationRepo.CreateUpdateDistrict(district);
        }

        public List<EPA> GetEPAs()
        {
            return _locationRepo.GetEPAs();
        }

        public List<Section> GetSections()
        {
            return _locationRepo.GetSections();
        }

        public List<EPA> GetEPAByDistrictId(int id)
        {
            return _locationRepo.GetEPAByDistrictId(id);
        }

        public List<Section> GetSectionByEPAId(int id)
        {
            return _locationRepo.GetSectionByEPAId(id);
        }

        public List<Region> GetRegions(int id)
        {
            return _locationRepo.GetRegions(id);
        }
    }
}
