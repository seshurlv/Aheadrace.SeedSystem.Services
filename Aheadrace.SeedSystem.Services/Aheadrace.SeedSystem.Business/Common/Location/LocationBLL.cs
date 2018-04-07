using Aheadrace.SeedSystem.Business.Contract.Common.Location;
using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.Repository.Common.Location;
using Aheadrace.SeedSystem.Repository.Contracts.Common.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Business.Common.Location
{
    public class LocationBLL : ILocationBLL
    {
        public List<Country> GetCountries()
        {
            ILocationRepository irepo = new LocationRepository();
            return irepo.GetCountries();
        }

        public List<State> GetStates()
        {
            ILocationRepository irepo = new LocationRepository();
            return irepo.GetStates();
        }

        public List<District> GetDistricts()
        {
            ILocationRepository irepo = new LocationRepository();
            return irepo.GetDistricts();
        }

        public List<EPA> GetEPAs()
        {
            ILocationRepository irepo = new LocationRepository();
            return irepo.GetEPAs();
        }

        public List<Section> GetSections()
        {
            ILocationRepository irepo = new LocationRepository();
            return irepo.GetSections();
        }

        public List<EPA> GetEPAByDistrictId(int id)
        {
            ILocationRepository irepo = new LocationRepository();
            return irepo.GetEPAByDistrictId(id);
        }

        public List<Section> GetSectionByEPAId(int id)
        {
            ILocationRepository irepo = new LocationRepository();
            return irepo.GetSectionByEPAId(id);
        }

        public List<Region> GetRegions(int id)
        {
            ILocationRepository irepo = new LocationRepository();
            return irepo.GetRegions(id);
        }
    }
}
