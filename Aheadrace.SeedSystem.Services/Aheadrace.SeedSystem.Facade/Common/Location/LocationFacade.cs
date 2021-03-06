﻿using Aheadrace.SeedSystem.Business.Common.Location;
using Aheadrace.SeedSystem.Business.Contract.Common.Location;
using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.Facade.Contracts.Common.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Facade.Common.Location
{
    public class LocationFacade : ILocationFacade
    {
        public List<Country> GetCountries()
        {
            ILocationBLL locationBll = new LocationBLL();
            return locationBll.GetCountries();
        }

        public List<State> GetStates()
        {
            ILocationBLL locationBll = new LocationBLL();
            return locationBll.GetStates();
        }

        public List<District> GetDistricts()
        {
            ILocationBLL locationBll = new LocationBLL();
            return locationBll.GetDistricts();
        }

        public List<EPA> GetEPAs()
        {
            ILocationBLL locationBll = new LocationBLL();
            return locationBll.GetEPAs();
        }

        public List<Section> GetSections()
        {
            ILocationBLL locationBll = new LocationBLL();
            return locationBll.GetSections();
        }

        public List<EPA> GetEPAByDistrictId(int id)
        {
            ILocationBLL locationBll = new LocationBLL();
            return locationBll.GetEPAByDistrictId(id);
        }

        public List<Section> GetSectionByEPAId(int id)
        {
            ILocationBLL locationBll = new LocationBLL();
            return locationBll.GetSectionByEPAId(id);
        }

        public List<Region> GetRegions(int id)
        {
            ILocationBLL locationBll = new LocationBLL();
            return locationBll.GetRegions(id);
        }
    }
}
