using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Framework.Data;
using Aheadrace.SeedSystem.Repository.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Repository.Users
{
    public class UsersRepository : IUserRepository
    {
        DataRepository dbRepo;
        public UsersRepository()
        {
            dbRepo = new DataRepository();
        }

        public User GetUserDetailsById(int id)
        {
            User user = new User();

            return user;
        }

        public User GetUserDetailsByUserName(string userName)
        {
            User user = new User();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@UserName", userName);
            
            DataSet ds = dbRepo.ExecuteProcedure("GetUserDetailsByUserName", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                user.UserID = Convert.ToInt32(ds.Tables[0].Rows[0]["UserID"]);
                user.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                user.MiddleName = ds.Tables[0].Rows[0]["MiddleName"].ToString();
                user.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
                user.UserName = Convert.ToString(ds.Tables[0].Rows[0]["UserName"]);
                user.Email = Convert.ToString(ds.Tables[0].Rows[0]["Email"]);
                user.MobileNumber = Convert.ToString(ds.Tables[0].Rows[0]["MobileNumber"]);
                user.Address = new DataContracts.Common.Address()
                {
                    AddressLine1 = Convert.ToString(ds.Tables[0].Rows[0]["Address"]),
                    PostalCode = Convert.ToString(ds.Tables[0].Rows[0]["PinCode"]),
                    Region = new DataContracts.Common.Region()
                    {
                        RegionID = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["RegionID"].ToString()) ? 0 : Convert.ToInt32(ds.Tables[0].Rows[0]["RegionID"]),
                        RegionName = ds.Tables[0].Rows[0]["RegionName"].ToString()
                    },
                    State = new DataContracts.Common.State()
                    {
                        StateName = ds.Tables[0].Rows[0]["State"].ToString()
                    },
                    Country = new DataContracts.Common.Country()
                    {
                        CountryName = ds.Tables[0].Rows[0]["Country"].ToString()
                    },
                    District = new DataContracts.Common.District()
                    {
                        DistrictName = Convert.ToString(ds.Tables[0].Rows[0]["District"])
                    },
                    EPA = new DataContracts.Common.EPA()
                    {
                        EPAName = Convert.ToString(ds.Tables[0].Rows[0]["EPA"])
                    },
                    Section = new DataContracts.Common.Section()
                    {
                        SectionName = Convert.ToString(ds.Tables[0].Rows[0]["SectionName"])
                    }

                };
                user.Role = new Role()
                {
                    RoleID = Convert.ToInt32(ds.Tables[0].Rows[0]["RoleID"]),
                    Name = ds.Tables[0].Rows[0]["RoleName"].ToString()
                };
            }
            return user;
        }

        public List<User> GetUsersList()
        {
            List<User> usersList = new List<User>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@UserID", 0);

            DataSet ds = dbRepo.ExecuteProcedure("GetUsers", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    User user = new User();
                    user.UserID = Convert.ToInt32(ds.Tables[0].Rows[i]["UserID"]);
                    user.FirstName = ds.Tables[0].Rows[i]["FirstName"].ToString();
                    user.MiddleName = ds.Tables[0].Rows[i]["MiddleName"].ToString();
                    user.LastName = ds.Tables[0].Rows[i]["LastName"].ToString();
                    user.Email = ds.Tables[0].Rows[i]["Email"].ToString();
                    user.MobileNumber = Convert.ToString(ds.Tables[0].Rows[i]["MobileNumber"]);
                    user.Address = new DataContracts.Common.Address()
                    {
                        Region = new DataContracts.Common.Region()
                        {
                            RegionID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegionID"]),
                            RegionName = ds.Tables[0].Rows[i]["RegionName"].ToString()
                        },
                        State = new DataContracts.Common.State()
                        {
                            StateName = ds.Tables[0].Rows[i]["State"].ToString()
                        },
                        Country = new DataContracts.Common.Country()
                        {
                            CountryName = ds.Tables[0].Rows[i]["Country"].ToString()
                        }
                    };
                    user.Role = new Role()
                    {
                        RoleID = Convert.ToInt32(ds.Tables[0].Rows[i]["RoleID"]),
                        Name = ds.Tables[0].Rows[i]["RoleName"].ToString()
                    };
                    usersList.Add(user);
                }                
            }
            return usersList;
        }

        public int CreateUser(User user)
        {
            int result = 0;
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@UserID", 0);
            cmdParams.Add("@FirstName", user.FirstName);
            cmdParams.Add("@MiddleName", user.MiddleName);
            cmdParams.Add("@LastName", user.LastName);
            cmdParams.Add("@Email", user.Email);
            cmdParams.Add("@MobileNumber", user.MobileNumber);
            cmdParams.Add("@UserName", user.UserName);
            cmdParams.Add("@Password", user.Password);
            cmdParams.Add("@PinCode", user.Address.PostalCode);
            cmdParams.Add("@Address", user.Address.AddressLine1);
            cmdParams.Add("@SectionId", user.Address.Section.ID);
            cmdParams.Add("@EPAId", user.Address.EPA.ID);
            cmdParams.Add("@DistrictId", user.Address.District.DistrictID);
            cmdParams.Add("@StateId", user.Address.State.StateID);
            cmdParams.Add("@CountryId", user.Address.Country.CountryID);
            cmdParams.Add("@RegionId", user.Address.Region.RegionID);
            cmdParams.Add("@RoleId", user.Role.RoleID);
            cmdParams.Add("@FarmAddress", user.FarmDetails.FarmAddress);
            cmdParams.Add("@FarmContact", user.FarmDetails.FarmContact);

            DataSet ds = dbRepo.ExecuteProcedure("CreateUser", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                result = Convert.ToInt32(ds.Tables[0].Rows[0]["Result"]);
            }
            return result;
        }

        public List<User> GetUsersByRole(int id)
        {
            List<User> usersList = new List<User>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@RoleID", id);

            DataSet ds = dbRepo.ExecuteProcedure("GetUsersByRole", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    User user = new User();
                    user.UserID = Convert.ToInt32(ds.Tables[0].Rows[i]["UserID"]);
                    user.FirstName = ds.Tables[0].Rows[i]["FirstName"].ToString();
                    user.MiddleName = ds.Tables[0].Rows[i]["MiddleName"].ToString();
                    user.LastName = ds.Tables[0].Rows[i]["LastName"].ToString();
                    user.Address = new DataContracts.Common.Address()
                    {
                        AddressLine1 = ds.Tables[0].Rows[i]["Address"].ToString(),
                        PostalCode = Convert.ToString(ds.Tables[0].Rows[i]["PinCode"]),
                        Region = new DataContracts.Common.Region()
                        {
                            RegionID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegionID"]),
                            RegionName = ds.Tables[0].Rows[i]["RegionName"].ToString()
                        },
                        State = new DataContracts.Common.State()
                        {
                            StateName = ds.Tables[0].Rows[i]["State"].ToString()
                        },
                        Country = new DataContracts.Common.Country()
                        {
                            CountryName = ds.Tables[0].Rows[i]["Country"].ToString()
                        },
                        District = new DataContracts.Common.District()
                        {
                            DistrictName = ds.Tables[0].Rows[i]["District"].ToString()
                        },
                        EPA = new DataContracts.Common.EPA()
                        {
                            EPAName = ds.Tables[0].Rows[i]["EPA"].ToString()
                        },
                        Section = new DataContracts.Common.Section()
                        {
                            SectionName = ds.Tables[0].Rows[i]["SectionName"].ToString()
                        }
                    };
                    user.Role = new Role()
                    {
                        RoleID = Convert.ToInt32(ds.Tables[0].Rows[i]["RoleID"]),
                        Name = ds.Tables[0].Rows[i]["RoleName"].ToString()
                    };
                    user.Email = ds.Tables[0].Rows[i]["Email"].ToString();
                    user.MobileNumber = ds.Tables[0].Rows[i]["MobileNumber"].ToString();                    
                    usersList.Add(user);
                }
            }
            return usersList;
        }

        public List<Role> GetRoles()
        {
            List<Role> rolesList = new List<Role>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();            

            DataSet ds = dbRepo.ExecuteProcedure("GetRoles", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Role role = new Role()
                    {
                        RoleID = Convert.ToInt32(ds.Tables[0].Rows[i]["RoleID"]),
                        Name = Convert.ToString(ds.Tables[0].Rows[i]["Name"])
                    };                    
                    rolesList.Add(role);
                }
            }
            return rolesList;
        }

        public List<User> GetGrowersWithOpenRegistrations()
        {
            List<User> usersList = new List<User>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();            

            DataSet ds = dbRepo.ExecuteProcedure("GetGrowersWithOpenRegistrations", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    User user = new User();
                    user.UserID = Convert.ToInt32(ds.Tables[0].Rows[i]["UserID"]);
                    user.FirstName = ds.Tables[0].Rows[i]["FirstName"].ToString();
                    user.MiddleName = ds.Tables[0].Rows[i]["MiddleName"].ToString();
                    user.LastName = ds.Tables[0].Rows[i]["LastName"].ToString();
                    user.Address = new DataContracts.Common.Address()
                    {
                        AddressLine1 = ds.Tables[0].Rows[i]["Address"].ToString(),
                        PostalCode = Convert.ToString(ds.Tables[0].Rows[i]["PinCode"]),
                        Region = new DataContracts.Common.Region()
                        {
                            RegionID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegionID"]),
                            RegionName = ds.Tables[0].Rows[i]["RegionName"].ToString()
                        },
                        State = new DataContracts.Common.State()
                        {
                            StateName = ds.Tables[0].Rows[i]["State"].ToString()
                        },
                        Country = new DataContracts.Common.Country()
                        {
                            CountryName = ds.Tables[0].Rows[i]["Country"].ToString()
                        },
                        District = new DataContracts.Common.District()
                        {
                            DistrictName = ds.Tables[0].Rows[i]["District"].ToString()
                        },
                        EPA = new DataContracts.Common.EPA()
                        {
                            EPAName = ds.Tables[0].Rows[i]["EPA"].ToString()
                        },
                        Section = new DataContracts.Common.Section()
                        {
                            SectionName = ds.Tables[0].Rows[i]["SectionName"].ToString()
                        }
                    };
                    user.Role = new Role()
                    {
                        RoleID = Convert.ToInt32(ds.Tables[0].Rows[i]["RoleID"]),
                        Name = ds.Tables[0].Rows[i]["RoleName"].ToString()
                    };
                    user.Email = ds.Tables[0].Rows[i]["Email"].ToString();
                    user.MobileNumber = ds.Tables[0].Rows[i]["MobileNumber"].ToString();
                    usersList.Add(user);
                }
            }
            return usersList;
        }
    }
}
