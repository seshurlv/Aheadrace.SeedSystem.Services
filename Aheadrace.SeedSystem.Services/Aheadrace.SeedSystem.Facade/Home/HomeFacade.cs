using Aheadrace.SeedSystem.Business.Contracts.Home;
using Aheadrace.SeedSystem.Business.Home;
using Aheadrace.SeedSystem.DataContracts.Home;
using Aheadrace.SeedSystem.Facade.Contracts.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Facade.Home
{
    public class HomeFacade : IHomeFacade
    {
        public List<RegistrationStats> GetRegistrationStats(int year)
        {
            IHomeBLL homeBll = new HomeBLL();
            return homeBll.GetRegistrationStats(year);
        }

        public List<CropsRegistered> GetRegistrationPerCrop(int year)
        {
            IHomeBLL homeBll = new HomeBLL();
            return homeBll.GetRegistrationPerCrop(year);
        }

        public List<CropsRegistered> GetAreaPerCrop(int year, int userId, int role)
        {
            IHomeBLL homeBll = new HomeBLL();
            return homeBll.GetAreaPerCrop(year, userId, role);
        }

        public List<RegistrationStats> GetUserRegistrationsPerMonth(int year)
        {
            IHomeBLL homeBll = new HomeBLL();
            return homeBll.GetUserRegistrationsPerMonth(year);
        }

        public List<RegistrationStats> GetUserPerDistrict(int year)
        {
            IHomeBLL homeBll = new HomeBLL();
            return homeBll.GetUserPerDistrict(year);
        }

        public List<RegistrationStats> GetInspectedGrowersPerMonth(int userId, int year)
        {
            IHomeBLL homeBll = new HomeBLL();
            return homeBll.GetInspectedGrowersPerMonth(userId, year);
        }

        public List<RegistrationStats> GetInspectorStats(int userId, int year, int role)
        {
            IHomeBLL homeBll = new HomeBLL();
            return homeBll.GetInspectorStats(userId, year, role);
        }
    }
}
