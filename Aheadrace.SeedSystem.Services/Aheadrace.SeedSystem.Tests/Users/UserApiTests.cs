using Aheadrace.SeedSystem.Business.Users;
using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Facade.Contracts.Users;
using Aheadrace.SeedSystem.Facade.Users;
using Aheadrace.SeedSystem.Repository.Users;
using Aheadrace.SeedSystem.Services.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Tests.Users
{
    [TestClass]
    public class UserApiTests
    {
        private UserController _userController;

        public UserApiTests()
        {
            _userController = new UserController(new UserFacade(new UserBLL(new UsersRepository())));
        }

        [TestMethod]
        public void GetUserDetailsByUserName()
        {
            string userName = "g1";
            var result = _userController.GetUserDetailsByUserName(userName);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetUsersList()
        {
            var result = _userController.GetUsersList();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetUsersByRole()
        {
            int id = 1;
            var result = _userController.GetUsersByRole(id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetRoles()
        {
            var result = _userController.GetRoles();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateUser()
        {
            User user = new User()
            {
                UserID = 53,
                FirstName = "test01",
                MiddleName = "",
                LastName = "user01",
                Email = "testuser01@abc.com",
                MobileNumber = "9376738922",
                UserName = "tu1",
                Password = "p",
                Role = new Role()
                {
                    RoleID = 1
                },
                Address = new DataContracts.Common.Address()
                {
                    AddressLine1 = "street5",
                    State = new DataContracts.Common.State()
                    {
                        StateID = 1
                    },
                    Country = new DataContracts.Common.Country()
                    {
                        CountryID = 1
                    },
                    District = new DataContracts.Common.District()
                    {
                        DistrictID = 2
                    },
                    EPA = new DataContracts.Common.EPA()
                    {
                        ID = 9
                    },
                    Section = new DataContracts.Common.Section()
                    {
                        ID = 1
                    },
                    PostalCode = "700098",
                    Region = new DataContracts.Common.Region()
                    {
                        RegionID = 4
                    }
                },
                FarmDetails = new List<FarmDetails>()
            };
            var result = _userController.CreateUser(user);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetGrowersWithOpenRegistrations()
        {
            var result = _userController.GetGrowersWithOpenRegistrations();
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void UpdateUser(User user)
        //{
        //    var result = _userController.UpdateUser(user);
        //    Assert.IsNotNull(result);
        //}
    }
}
