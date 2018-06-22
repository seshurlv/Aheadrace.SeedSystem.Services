using Aheadrace.SeedSystem.DataContracts.Products;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Business.Contracts.Admin
{
    public interface IAdminBLL
    {
        int RegisterInspection(InspectionRegistration inspectionReg);

        List<InspectionRegistration> GetRegistrationsByUser(int mode, int userId);

        int AssignInspector(InspectionRegistration inspectionReg);

        int SaveInspectorObservation(InspectorObservation inspectorObservation);

        List<InspectorObservation> GetObservationsByUser(int mode, int userId);

        InspectorObservation GetObservationsByRegId(int regId);
    }
}
