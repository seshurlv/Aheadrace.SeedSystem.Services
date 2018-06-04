using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Facade.Admin;
using Aheadrace.SeedSystem.Facade.Contracts.Admin;
using Aheadrace.SeedSystem.Services.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Caching;
using Aheadrace.SeedSystem.DataContracts.Common;

namespace Aheadrace.SeedSystem.Services.Controllers
{
    [JWTAuthentication]
    public class AdminController : ApiController
    {
        [HttpPost]
        public int RegisterInspection(InspectionRegistration inspectionReg)
        {
            IAdminFacade adminFacade = new AdminFacade();
            return adminFacade.RegisterInspection(inspectionReg);
        }

        [HttpGet]
        public List<InspectionRegistration> GetRegistrationsByUser(int mode, int userId)
        {
            IAdminFacade adminFacade = new AdminFacade();
            return adminFacade.GetRegistrationsByUser(mode, userId);
        }

        [HttpPost]        
        public int AssignInspector(InspectionRegistration inspectionReg)
        {
            IAdminFacade adminFacade = new AdminFacade();
            return adminFacade.AssignInspector(inspectionReg);
        }

        [HttpPost]
        public int SaveInspectorObservation(InspectorObservation inspectorObservation)
        {
            IAdminFacade adminFacade = new AdminFacade();
            return adminFacade.SaveInspectorObservation(inspectorObservation);
        }

        [HttpGet]
        public List<InspectorObservation> GetObservationsByUser(int mode, int userId)
        {
            IAdminFacade adminFacade = new AdminFacade();
            return adminFacade.GetObservationsByUser(mode, userId);
        }

        [HttpGet]
        public InspectorObservation GetObservationsByRegId(int regId)
        {
            IAdminFacade adminFacade = new AdminFacade();
            return adminFacade.GetObservationsByRegId(regId);
        }



    }
}
