using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.DataContracts.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Repository.Contracts.Admin
{
    public interface IAdminRepository
    {
        int RegisterInspection(InspectionRegistration inspectionReg);

        DataSet GetRegistrationsByUser(int mode, int userId);

        int AssignInspector(InspectionRegistration inspectionReg);

        int SaveInspectorObservation(InspectorObservation inspectorObservation);

        List<InspectorObservation> GetObservationsByUser(int mode, int userId);
        
    }
}
