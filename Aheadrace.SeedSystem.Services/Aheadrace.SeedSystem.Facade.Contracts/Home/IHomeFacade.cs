using Aheadrace.SeedSystem.DataContracts.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Facade.Contracts.Home
{
    public interface IHomeFacade
    {
        List<RegistrationStats> GetRegistrationStats(int year);

        List<CropsRegistered> GetRegistrationPerCrop(int year);

        List<CropsRegistered> GetAreaPerCrop(int year);

        List<RegistrationStats> GetUserRegistrationsPerMonth(int year);

        List<RegistrationStats> GetUserPerDistrict(int year);

        List<RegistrationStats> GetInspectedGrowersPerMonth(int userId, int year);

        List<RegistrationStats> GetInspectorStats(int userId, int year);
    }
}
