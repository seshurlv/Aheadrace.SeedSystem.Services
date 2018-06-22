using Aheadrace.SeedSystem.Business.Contracts.Home;
using Aheadrace.SeedSystem.DataContracts.Home;
using Aheadrace.SeedSystem.Repository.Contracts.Home;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Business.Home
{
    public class HomeBLL : IHomeBLL
    {
        private IHomeRepository _homeRepo;

        public HomeBLL(IHomeRepository homeRepo)
        {
            _homeRepo = homeRepo;
        }

        public List<RegistrationStats> GetRegistrationStats(int year)
        {
            return _homeRepo.GetRegistrationStats(year);
        }

        public List<CropsRegistered> GetRegistrationPerCrop(int year)
        {
            return _homeRepo.GetRegistrationPerCrop(year);
        }

        public List<CropsRegistered> GetAreaPerCrop(int year, int userId, int role)
        {
            return _homeRepo.GetAreaPerCrop(year, userId, role);
        }

        public List<RegistrationStats> GetUserRegistrationsPerMonth(int year)
        {
            return _homeRepo.GetUserRegistrationsPerMonth(year);
        }

        public List<RegistrationStats> GetUserPerDistrict(int year)
        {
            return _homeRepo.GetUserPerDistrict(year);
        }

        public List<RegistrationStats> GetInspectedGrowersPerMonth(int userId, int year)
        {
            return _homeRepo.GetInspectedGrowersPerMonth(userId, year);
        }

        public List<RegistrationStats> GetInspectorStats(int userId, int year, int role)
        {
            return _homeRepo.GetInspectorStats(userId, year, role);
        }
    }
}
