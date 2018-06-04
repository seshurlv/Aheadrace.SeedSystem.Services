using Aheadrace.SeedSystem.DataContracts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Business.Contract.Common.Location
{
    public interface ILocationBLL
    {
        List<Country> GetCountries();

        int CreateUpdateCountry(Country country);

        List<State> GetStates();

        List<State> GetStatesByCountryId(int CountryId);

        int CreateUpdateState(State state);

        List<District> GetDistricts();

        int CreateUpdateDistrict(District district);

        List<EPA> GetEPAs();

        List<Section> GetSections();

        List<EPA> GetEPAByDistrictId(int id);

        List<Section> GetSectionByEPAId(int id);

        List<Region> GetRegions(int id);
    }
}
