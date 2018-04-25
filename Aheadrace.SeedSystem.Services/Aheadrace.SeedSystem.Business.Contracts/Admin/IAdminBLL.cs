using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.DataContracts.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Business.Contracts.Admin
{
    public interface IAdminBLL
    {
        int RegisterInspection(InspectionRegistration inspectionReg);

        List<InspectionRegistration> GetRegistrationsByUser(int mode, int userId);

        int AssignInspector(InspectionRegistration inspectionReg);

        int SaveInspectorObservation(InspectorObservation inspectorObservation);

        List<InspectorObservation> GetObservationsByUser(int mode, int userId);

        
    }
}
