using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.DataContracts.Products
{
    public class InspectorObservation : Common.Common
    {
        public int ID { get; set; }
        public int RegID { get; set; }
        public string OffTypePlants { get; set; }
        public string PestDiseaseScore { get; set; }
        public string PlantingPattern { get; set; }
        public string PollinatingFemales { get; set; }
        public string FemaleReceptiveSilks { get; set; }
        public string MaleElimination { get; set; }
        public string OffTypeCobs { get; set; }
        public string DefectiveCobs { get; set; }
        public string RemarksByInspector { get; set; }
        public string RecommendationForGrower { get; set; }
        public string Status { get; set; }
        public DateTime DateOfSowing { get; set; }
        public string CropStage { get; set; }
        public bool IsIsolationDistanceMaintained { get; set; }
        public string GrowthCondition { get; set; }
        public bool RecommendationForCertification { get; set; }

        public InspectionRegistration InspectionRegistration { get; set; }
    }
}
