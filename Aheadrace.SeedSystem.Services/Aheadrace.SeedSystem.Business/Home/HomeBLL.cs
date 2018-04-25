using Aheadrace.SeedSystem.Business.Contracts.Home;
using Aheadrace.SeedSystem.DataContracts.Home;
using Aheadrace.SeedSystem.Repository.Contracts.Home;
using Aheadrace.SeedSystem.Repository.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Business.Home
{
    public class HomeBLL : IHomeBLL
    {
        public List<RegistrationStats> GetRegistrationStats(int year)
        {
            IHomeRepository homeRepo = new HomeRepository();
            return homeRepo.GetRegistrationStats(year);
        }

        public List<CropsRegistered> GetRegistrationPerCrop(int year)
        {
            IHomeRepository homeRepo = new HomeRepository();
            return homeRepo.GetRegistrationPerCrop(year);
        }

        public List<CropsRegistered> GetAreaPerCrop(int year)
        {
            IHomeRepository homeRepo = new HomeRepository();
            return homeRepo.GetAreaPerCrop(year);
        }

        public List<RegistrationStats> GetUserRegistrationsPerMonth(int year)
        {
            IHomeRepository homeRepo = new HomeRepository();
            return homeRepo.GetUserRegistrationsPerMonth(year);
        }

        public List<RegistrationStats> GetUserPerDistrict(int year)
        {
            IHomeRepository homeRepo = new HomeRepository();
            return homeRepo.GetUserPerDistrict(year);
        }

        public List<RegistrationStats> GetInspectedGrowersPerMonth(int userId, int year)
        {
            IHomeRepository homeRepo = new HomeRepository();
            return homeRepo.GetInspectedGrowersPerMonth(userId, year);
        }

        public List<RegistrationStats> GetInspectorStats(int userId, int year)
        {
            IHomeRepository homeRepo = new HomeRepository();
            return homeRepo.GetInspectorStats(userId, year);
        }
    }
}
