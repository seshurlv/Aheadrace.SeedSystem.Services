using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aheadrace.SeedSystem.Facade.Contracts.Common.Location;
using Aheadrace.SeedSystem.Facade.Common.Location;
using Aheadrace.SeedSystem.Business.Common.Location;
using Aheadrace.SeedSystem.Repository.Common.Location;
using Aheadrace.SeedSystem.Services.Controllers;
using Aheadrace.SeedSystem.DataContracts.Common;

namespace Aheadrace.SeedSystem.Tests.Common.Location
{
    [TestClass]
    public class LocationUnitTest
    {
        private LocationController _locController;

        public LocationUnitTest()
        {
            _locController = new LocationController(new LocationFacade(new LocationBLL(new LocationRepository())));
        }

        [TestMethod]
        public void GetCountries()
        {
            var result = _locController.GetCountries();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateUpdateCountry()
        {
            Country country = new Country()
            {
                CountryID = 9,
                CountryName = "testCountry",
                CountryCode = "tc1",
                CountryPhoneCode = "12",
                CountryDescription = "this is test country"
            };
            var result = _locController.CreateUpdateCountry(country);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetStates()
        {
            var result = _locController.GetStates();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateUpdateState()
        {
            State state = new State()
            {
                StateID = 2,
                StateName = "testState",
                StateDescription = "this is test state",
                Country = new Country()
                {
                    CountryID = 1
                },
                Region = new Region()
                {
                    RegionID = 3
                }
            };
            var result = _locController.CreateUpdateState(state);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetStatesByCountryId()
        {
            int countryId = 1;
            var result = _locController.GetStatesByCountryId(countryId);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetDistricts()
        {
            var result = _locController.GetDistricts();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateUpdateDistrict()
        {
            District district = new District(){
                DistrictID = 31,
                DistrictName = "Gadwal",
                DistrictDescription = "This is is telangana state",
                State = new State()
                {
                    StateID = 1                    
                }
            };
            var result = _locController.CreateUpdateDistrict(district);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetEPAs()
        {
            var result = _locController.GetEPAs();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetSections()
        {
            var result = _locController.GetSections();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetEPAByDistrictId()
        {
            int id = 4;
            var result = _locController.GetEPAByDistrictId(id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetSectionByEPAId()
        {
            int id = 10;
            var result = _locController.GetSectionByEPAId(id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetRegions()
        {
            var id = 0;
            var result = _locController.GetRegions(id);
            Assert.IsNotNull(result);
        }
    }
}
