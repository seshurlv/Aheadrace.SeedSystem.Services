using Aheadrace.SeedSystem.Business.Contracts.Home;
using Aheadrace.SeedSystem.DataContracts.Home;
using Aheadrace.SeedSystem.Facade.Contracts.Home;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Facade.Home
{
    public class HomeFacade : IHomeFacade
    {
        private IHomeBLL _homeBll;

        public HomeFacade(IHomeBLL homeBll)
        {
            _homeBll = homeBll;
        }

        public List<RegistrationStats> GetRegistrationStats(int year)
        {
            return _homeBll.GetRegistrationStats(year);
        }

        public List<CropsRegistered> GetRegistrationPerCrop(int year)
        {
            return _homeBll.GetRegistrationPerCrop(year);
        }

        public List<CropsRegistered> GetAreaPerCrop(int year, int userId, int role)
        {
            return _homeBll.GetAreaPerCrop(year, userId, role);
        }

        public List<RegistrationStats> GetUserRegistrationsPerMonth(int year)
        {
            return _homeBll.GetUserRegistrationsPerMonth(year);
        }

        public List<RegistrationStats> GetUserPerDistrict(int year)
        {
            return _homeBll.GetUserPerDistrict(year);
        }

        public List<RegistrationStats> GetInspectedGrowersPerMonth(int userId, int year)
        {
            return _homeBll.GetInspectedGrowersPerMonth(userId, year);
        }

        public List<RegistrationStats> GetInspectorStats(int userId, int year, int role)
        {
            return _homeBll.GetInspectorStats(userId, year, role);
        }
    }
}
