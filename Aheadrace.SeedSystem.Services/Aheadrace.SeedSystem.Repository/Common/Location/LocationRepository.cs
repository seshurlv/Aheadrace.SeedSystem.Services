using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.Framework.Data;
using Aheadrace.SeedSystem.Repository.Contracts.Common.Location;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Repository.Common.Location
{
    public class LocationRepository : ILocationRepository
    {
        DataRepository dbRepo;
        public LocationRepository()
        {
            dbRepo = new DataRepository();
        }

        public List<Country> GetCountries()
        {
            List<Country> countriesList = new List<Country>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            DataSet ds = dbRepo.ExecuteProcedure("GetCountries", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Country country = new Country()
                    {
                        CountryID = Convert.ToInt32(ds.Tables[0].Rows[i]["CountryID"]),
                        CountryCode = Convert.ToString(ds.Tables[0].Rows[i]["CountryCode"]),
                        CountryName = Convert.ToString(ds.Tables[0].Rows[i]["Name"])
                    };
                    countriesList.Add(country);
                }
            }
            return countriesList;
        }

        public List<State> GetStates()
        {
            List<State> statesList = new List<State>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            DataSet ds = dbRepo.ExecuteProcedure("GetStates", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    State state = new State()
                    {
                        StateID = Convert.ToInt32(ds.Tables[0].Rows[i]["StateID"]),
                        StateName = Convert.ToString(ds.Tables[0].Rows[i]["StateName"]),
                        Country = new Country()
                        {
                            CountryName = Convert.ToString(ds.Tables[0].Rows[i]["CountryName"])
                        }
                    };
                    statesList.Add(state);
                }
            }
            return statesList;
        }

        public List<District> GetDistricts()
        {
            List<District> districtList = new List<District>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            DataSet ds = dbRepo.ExecuteProcedure("GetDistricts", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    District district = new District()
                    {
                        DistrictID = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"]),
                        DistrictName = Convert.ToString(ds.Tables[0].Rows[i]["DistrictName"]),
                        State = new State()
                        {
                            StateName = Convert.ToString(ds.Tables[0].Rows[i]["StateName"]),
                            Country = new Country()
                            {
                                CountryName = Convert.ToString(ds.Tables[0].Rows[i]["CountryName"])
                            }
                        }                        
                    };
                    districtList.Add(district);
                }
            }
            return districtList;
        }

        public List<EPA> GetEPAs()
        {
            List<EPA> epaList = new List<EPA>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            DataSet ds = dbRepo.ExecuteProcedure("GetEPAs", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    EPA epa = new EPA()
                    {
                        ID = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"]),
                        EPAName = Convert.ToString(ds.Tables[0].Rows[i]["EPA"]),
                        Description = Convert.ToString(ds.Tables[0].Rows[i]["Description"]),
                        District = new District()
                        {
                            DistrictName = Convert.ToString(ds.Tables[0].Rows[i]["DistrictName"]),
                            State = new State()
                            {
                                StateName = Convert.ToString(ds.Tables[0].Rows[i]["StateName"]),
                                Country = new Country()
                                {
                                    CountryName = Convert.ToString(ds.Tables[0].Rows[i]["CountryName"])
                                }
                            }
                        }
                    };
                    epaList.Add(epa);
                }
            }
            return epaList;
        }

        public List<Section> GetSections()
        {
            List<Section> sectionList = new List<Section>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            DataSet ds = dbRepo.ExecuteProcedure("GetSections", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Section section = new Section()
                    {
                        ID = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"]),
                        SectionName = Convert.ToString(ds.Tables[0].Rows[i]["SectionName"]),
                        Description = Convert.ToString(ds.Tables[0].Rows[i]["Description"]),
                        EPA = new EPA()
                        {
                            EPAName = Convert.ToString(ds.Tables[0].Rows[i]["EPAName"]),
                            District = new District()
                            {
                                DistrictName = Convert.ToString(ds.Tables[0].Rows[i]["DistrictName"]),
                                State = new State()
                                {
                                    StateName = Convert.ToString(ds.Tables[0].Rows[i]["StateName"]),
                                    Country = new Country()
                                    {
                                        CountryName = Convert.ToString(ds.Tables[0].Rows[i]["CountryName"])
                                    }
                                }
                            }
                        }
                    };
                    sectionList.Add(section);
                }
            }
            return sectionList;
        }

        public List<EPA> GetEPAByDistrictId(int id)
        {
            List<EPA> epaList = new List<EPA>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@ID", id);
            DataSet ds = dbRepo.ExecuteProcedure("GetEPAByDistrictId", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    EPA epa = new EPA()
                    {
                        ID = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"]),
                        EPAName = Convert.ToString(ds.Tables[0].Rows[i]["EPA"]),
                        Description = Convert.ToString(ds.Tables[0].Rows[i]["Description"]),
                        District = new District()
                        {
                            DistrictName = Convert.ToString(ds.Tables[0].Rows[i]["DistrictName"]),
                            State = new State()
                            {
                                StateName = Convert.ToString(ds.Tables[0].Rows[i]["StateName"]),
                                Country = new Country()
                                {
                                    CountryName = Convert.ToString(ds.Tables[0].Rows[i]["CountryName"])
                                }
                            }
                        }
                    };
                    epaList.Add(epa);
                }
            }
            return epaList;
        }

        public List<Section> GetSectionByEPAId(int id)
        {
            List<Section> sectionList = new List<Section>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@ID", id);

            DataSet ds = dbRepo.ExecuteProcedure("GetSectionsByEPAId", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Section section = new Section()
                    {
                        ID = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"]),
                        SectionName = Convert.ToString(ds.Tables[0].Rows[i]["SectionName"]),
                        Description = Convert.ToString(ds.Tables[0].Rows[i]["Description"]),
                        EPA = new EPA()
                        {
                            EPAName = Convert.ToString(ds.Tables[0].Rows[i]["EPAName"]),
                            District = new District()
                            {
                                DistrictName = Convert.ToString(ds.Tables[0].Rows[i]["DistrictName"]),
                                State = new State()
                                {
                                    StateName = Convert.ToString(ds.Tables[0].Rows[i]["StateName"]),
                                    Country = new Country()
                                    {
                                        CountryName = Convert.ToString(ds.Tables[0].Rows[i]["CountryName"])
                                    }
                                }
                            }
                        }
                    };
                    sectionList.Add(section);
                }
            }
            return sectionList;
        }

        public List<Region> GetRegions(int id)
        {
            List<Region> regionList = new List<Region>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@ID", id);

            DataSet ds = dbRepo.ExecuteProcedure("GetRegions", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Region region = new Region()
                    {
                        RegionID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegionID"]),
                        RegionName = Convert.ToString(ds.Tables[0].Rows[i]["RegionName"]),
                        RegionDescription = Convert.ToString(ds.Tables[0].Rows[i]["Description"])                        
                    };
                    regionList.Add(region);
                }
            }
            return regionList;
        }
    }
}
