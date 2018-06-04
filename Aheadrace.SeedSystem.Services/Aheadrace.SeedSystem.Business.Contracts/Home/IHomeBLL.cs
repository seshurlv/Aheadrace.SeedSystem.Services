using Aheadrace.SeedSystem.DataContracts.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Business.Contracts.Home
{
    public interface IHomeBLL
    {
        List<RegistrationStats> GetRegistrationStats(int year);

        List<CropsRegistered> GetRegistrationPerCrop(int year);

        List<CropsRegistered> GetAreaPerCrop(int year, int userId, int role);

        List<RegistrationStats> GetUserRegistrationsPerMonth(int year);

        List<RegistrationStats> GetUserPerDistrict(int year);

        List<RegistrationStats> GetInspectedGrowersPerMonth(int userId, int year);

        List<RegistrationStats> GetInspectorStats(int userId, int year, int role);
    }
}
