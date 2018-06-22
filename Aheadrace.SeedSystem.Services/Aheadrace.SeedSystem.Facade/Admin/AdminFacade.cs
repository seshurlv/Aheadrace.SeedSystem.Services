using Aheadrace.SeedSystem.Business.Contracts.Admin;
using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Facade.Contracts.Admin;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Facade.Admin
{
    public class AdminFacade : IAdminFacade
    {
        private IAdminBLL _adminBll;

        public AdminFacade(IAdminBLL adminBll)
        {
            _adminBll = adminBll;
        }

        public int RegisterInspection(InspectionRegistration inspectionReg)
        {
            return _adminBll.RegisterInspection(inspectionReg);
        }
        
        public List<InspectionRegistration> GetRegistrationsByUser(int mode, int userId)
        {
            return _adminBll.GetRegistrationsByUser(mode, userId);
        }

        public int AssignInspector(InspectionRegistration inspectionReg)
        {
            return _adminBll.AssignInspector(inspectionReg);
        }

        public int SaveInspectorObservation(InspectorObservation inspectorObservation)
        {
            return _adminBll.SaveInspectorObservation(inspectorObservation);
        }

        public List<InspectorObservation> GetObservationsByUser(int mode, int userId)
        {
            return _adminBll.GetObservationsByUser(mode, userId);
        }

        public InspectorObservation GetObservationsByRegId(int regId)
        {
            return _adminBll.GetObservationsByRegId(regId);
        }
    }
}
