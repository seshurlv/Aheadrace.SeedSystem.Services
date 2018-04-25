using Aheadrace.SeedSystem.DataContracts.Home;
using Aheadrace.SeedSystem.Framework.Data;
using Aheadrace.SeedSystem.Repository.Contracts.Home;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Repository.Home
{
    public class HomeRepository : IHomeRepository
    {
        DataRepository dbRepo;
        public HomeRepository()
        {
            dbRepo = new DataRepository();
        }

        public List<RegistrationStats> GetRegistrationStats(int year)
        {
            List<RegistrationStats> regStatsList = new List<RegistrationStats>();
            string[] tableNames = new string[2];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@year", year);
            DataSet ds = dbRepo.ExecuteProcedure("GetRegistrationStats", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    RegistrationStats rg = new RegistrationStats()
                    {
                        Month = Convert.ToString(ds.Tables[0].Rows[i]["Month"]),
                        RegistrationCount = Convert.ToInt32(ds.Tables[0].Rows[i]["RegisteredCount"]),
                        InspectedCount = Convert.ToInt32(ds.Tables[0].Rows[i]["InspectedCount"]),
                    };
                    regStatsList.Add(rg);
                }
            }
            return regStatsList;
        }

        public List<CropsRegistered> GetRegistrationPerCrop(int year)
        {
            List<CropsRegistered> regStatsList = new List<CropsRegistered>();
            string[] tableNames = new string[2];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@year", year);
            DataSet ds = dbRepo.ExecuteProcedure("GetRegistrationPerCrop", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CropsRegistered rg = new CropsRegistered()
                    {
                        CropName = Convert.ToString(ds.Tables[0].Rows[i]["Name"]),                        
                        RegistrationCount = Convert.ToInt32(ds.Tables[0].Rows[i]["RegistrationsCount"])                        
                    };
                    regStatsList.Add(rg);
                }
            }
            return regStatsList;
        }

        public List<CropsRegistered> GetAreaPerCrop(int year)
        {
            List<CropsRegistered> regStatsList = new List<CropsRegistered>();
            string[] tableNames = new string[2];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@year", year);
            DataSet ds = dbRepo.ExecuteProcedure("GetAreaPerCrop", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    CropsRegistered rg = new CropsRegistered()
                    {
                        CropName = Convert.ToString(ds.Tables[0].Rows[i]["Name"]),
                        CropArea = Convert.ToDecimal(ds.Tables[0].Rows[i]["Area"])
                    };
                    regStatsList.Add(rg);
                }
            }
            return regStatsList;
        }

        public List<RegistrationStats> GetUserRegistrationsPerMonth(int year)
        {
            List<RegistrationStats> regStatsList = new List<RegistrationStats>();
            string[] tableNames = new string[2];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@year", year);
            DataSet ds = dbRepo.ExecuteProcedure("GetUserRegistrationsPerMonth", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    RegistrationStats rg = new RegistrationStats()
                    {
                        Month = Convert.ToString(ds.Tables[0].Rows[i]["Month"]),
                        UserRegistrationCount = Convert.ToInt32(ds.Tables[0].Rows[i]["UsersCount"])
                    };
                    regStatsList.Add(rg);
                }
            }
            return regStatsList;
        }

        public List<RegistrationStats> GetUserPerDistrict(int year)
        {
            List<RegistrationStats> regStatsList = new List<RegistrationStats>();
            string[] tableNames = new string[2];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@year", year);
            DataSet ds = dbRepo.ExecuteProcedure("GetUserPerDistrict", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    RegistrationStats rg = new RegistrationStats()
                    {
                        DistrictName = Convert.ToString(ds.Tables[0].Rows[i]["DistrictName"]),
                        UserRegistrationCount = Convert.ToInt32(ds.Tables[0].Rows[i]["UsersCount"])
                    };
                    regStatsList.Add(rg);
                }
            }
            return regStatsList;
        }

        public List<RegistrationStats> GetInspectedGrowersPerMonth(int userId, int year)
        {
            List<RegistrationStats> regStatsList = new List<RegistrationStats>();
            string[] tableNames = new string[2];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@inspectorId", userId);
            cmdParams.Add("@year", year);
            DataSet ds = dbRepo.ExecuteProcedure("GetInspectedGrowersPerMonth", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    RegistrationStats rg = new RegistrationStats()
                    {
                        Month = Convert.ToString(ds.Tables[0].Rows[i]["Month"]),
                        InspectedCount = Convert.ToInt32(ds.Tables[0].Rows[i]["InspectedCount"])
                    };
                    regStatsList.Add(rg);
                }
            }
            return regStatsList;
        }

        public List<RegistrationStats> GetInspectorStats(int userId, int year)
        {
            List<RegistrationStats> regStatsList = new List<RegistrationStats>();
            string[] tableNames = new string[2];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@inspectorId", userId);
            cmdParams.Add("@year", year);
            DataSet ds = dbRepo.ExecuteProcedure("GetInspectorStats", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    RegistrationStats rg = new RegistrationStats()
                    {
                        Status = Convert.ToString(ds.Tables[0].Rows[i]["Status"]),
                        Count = Convert.ToInt32(ds.Tables[0].Rows[i]["Count"])
                    };
                    regStatsList.Add(rg);
                }
            }
            return regStatsList;
        }
    }
}
