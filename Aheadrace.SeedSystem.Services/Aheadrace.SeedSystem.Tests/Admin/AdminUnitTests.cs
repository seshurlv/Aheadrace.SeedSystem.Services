using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aheadrace.SeedSystem.Facade.Contracts.Admin;
using Aheadrace.SeedSystem.Facade.Admin;
using Aheadrace.SeedSystem.Business.Admin;
using Aheadrace.SeedSystem.Repository.Admin;
using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Services.Controllers;

namespace Aheadrace.SeedSystem.Tests.Admin
{
    [TestClass]
    public class AdminUnitTests
    {
        private AdminController _adminController;

        public AdminUnitTests()
        {
            _adminController = new AdminController(new AdminFacade(new AdminBLL(new AdminRepository())));
        }

        [TestMethod]
        public void RegisterInspection()
        {
            InspectionRegistration inspectionReg = new InspectionRegistration()
            {
                GrowerId = 10,
                ProductCategoryId = 13,
                ProductId = 1,
                Area = "5 hec",
                PlantingDate = DateTime.UtcNow,
                SeedClassId = 2,
                SeedSource = "ICRISAT",
                Certificate = "Cert 1",
                SeedLot = "JuneLot1",
                CroppingHistory = "Maize",
                Remarks = "remarks 001",
                SeedSourceEvidence = false,
                GPS = "GPS",
                PaymentOption = "CreditCard",
                Status = "Registered"
            };
            var result = _adminController.RegisterInspection(inspectionReg);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetRegistrationsByUser()
        {
            int mode = 2;
            int userId = 9;
            var result = _adminController.GetRegistrationsByUser(mode, userId);
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void AssignInspector()
        //{
        //    InspectionRegistration inspectionReg = new InspectionRegistration();
        //    var result = _adminController.AssignInspector(inspectionReg);
        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void SaveInspectorObservation()
        //{
        //    InspectorObservation inspectorObservation = new InspectorObservation();
        //    var result = _adminController.SaveInspectorObservation(inspectorObservation);
        //    Assert.IsNotNull(result);
        //}

        [TestMethod]
        public void GetObservationsByUser()
        {
            int mode = 0;
            int userId = 10;
            var result = _adminController.GetObservationsByUser(mode, userId);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetObservationsByRegId()
        {
            int regId = 125;
            var result = _adminController.GetObservationsByRegId(regId);
            Assert.IsNotNull(result);
        }
    }
}
