using Aheadrace.SeedSystem.Business.Admin;
using Aheadrace.SeedSystem.Business.Contracts.Admin;
using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Facade.Contracts.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Facade.Admin
{
    public class AdminFacade : IAdminFacade
    {
        public int RegisterInspection(InspectionRegistration inspectionReg)
        {
            IAdminBLL adminBll = new AdminBLL();
            return adminBll.RegisterInspection(inspectionReg);
        }
        

        public List<InspectionRegistration> GetRegistrationsByUser(int mode, int userId)
        {
            IAdminBLL adminBll = new AdminBLL();
            return adminBll.GetRegistrationsByUser(mode, userId);
        }

        public int AssignInspector(InspectionRegistration inspectionReg)
        {
            IAdminBLL adminBll = new AdminBLL();
            return adminBll.AssignInspector(inspectionReg);
        }

        public int SaveInspectorObservation(InspectorObservation inspectorObservation)
        {
            IAdminBLL adminBll = new AdminBLL();
            return adminBll.SaveInspectorObservation(inspectorObservation);
        }

        public List<InspectorObservation> GetObservationsByUser(int mode, int userId)
        {
            IAdminBLL adminBll = new AdminBLL();
            return adminBll.GetObservationsByUser(mode, userId);
        }

        
    }
}
