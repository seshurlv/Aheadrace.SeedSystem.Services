using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Facade.Contracts.Admin;
using Aheadrace.SeedSystem.Services.Filters;
using System.Collections.Generic;
using System.Web.Http;

namespace Aheadrace.SeedSystem.Services.Controllers
{
    [JWTAuthentication]
    public class AdminController : ApiController
    {
        private IAdminFacade _adminFacade;

        public AdminController(IAdminFacade adminFacade)
        {
            _adminFacade = adminFacade;
        }

        [HttpPost]
        public int RegisterInspection(InspectionRegistration inspectionReg)
        {
            return _adminFacade.RegisterInspection(inspectionReg);
        }

        [HttpGet]
        public List<InspectionRegistration> GetRegistrationsByUser(int mode, int userId)
        {
            return _adminFacade.GetRegistrationsByUser(mode, userId);
        }

        [HttpPost]        
        public int AssignInspector(InspectionRegistration inspectionReg)
        {
            return _adminFacade.AssignInspector(inspectionReg);
        }

        [HttpPost]
        public int SaveInspectorObservation(InspectorObservation inspectorObservation)
        {
            return _adminFacade.SaveInspectorObservation(inspectorObservation);
        }

        [HttpGet]
        public List<InspectorObservation> GetObservationsByUser(int mode, int userId)
        {
            return _adminFacade.GetObservationsByUser(mode, userId);
        }

        [HttpGet]
        public InspectorObservation GetObservationsByRegId(int regId)
        {
            return _adminFacade.GetObservationsByRegId(regId);
        }
    }
}
