﻿using Aheadrace.SeedSystem.DataContracts.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Repository.Contracts.Home
{
    public interface IHomeRepository
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
