using Aheadrace.SeedSystem.DataContracts.Common;
using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Framework.Data;
using Aheadrace.SeedSystem.Repository.Contracts.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Repository.Admin
{
    public class AdminRepository : IAdminRepository
    {
        DataRepository dbRepo;
        public AdminRepository()
        {
            dbRepo = new DataRepository();
        }

        public int RegisterInspection(InspectionRegistration inspectionReg)
        {
            int result = 0;
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@GrowerId", inspectionReg.GrowerId);
            cmdParams.Add("@ProductCategoryId", inspectionReg.ProductCategoryId);
            cmdParams.Add("@ProductId", inspectionReg.ProductId);
            cmdParams.Add("@Area", inspectionReg.Area);
            cmdParams.Add("@PlantingDate", inspectionReg.PlantingDate);
            cmdParams.Add("@SeedClassId", inspectionReg.SeedClassId);
            cmdParams.Add("@SeedSource", inspectionReg.SeedSource);
            cmdParams.Add("@Certificate", inspectionReg.Certificate);
            cmdParams.Add("@SeedLot", inspectionReg.SeedLot);
            cmdParams.Add("@CroppingHistory", inspectionReg.CroppingHistory);
            cmdParams.Add("@Remarks", inspectionReg.Remarks);
            cmdParams.Add("@SeedSourceEvidence", inspectionReg.SeedSourceEvidence);
            cmdParams.Add("@GPS", inspectionReg.GPS);
            cmdParams.Add("@PaymentOption", inspectionReg.PaymentOption);
            cmdParams.Add("@Status", inspectionReg.Status);
            
            DataSet ds = dbRepo.ExecuteProcedure("CreateInspectionRegistration", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                result = Convert.ToInt32(ds.Tables[0].Rows[0]["Result"]);
            }
            return result;
        }

        public DataSet GetRegistrationsByUser(int mode, int userId)
        {
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@mode", mode);
            cmdParams.Add("@userId", userId);

            return dbRepo.ExecuteProcedure("GetRegistrationsByUser", 0, tableNames, cmdParams);
        }

        public int AssignInspector(InspectionRegistration inspectionReg)
        {
            int result = 0;
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@RegId", inspectionReg.ID);            
            cmdParams.Add("@InspectorId", inspectionReg.InspectorId);            
            cmdParams.Add("@Status", inspectionReg.Status);

            DataSet ds = dbRepo.ExecuteProcedure("AssignInspector", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                result = Convert.ToInt32(ds.Tables[0].Rows[0]["Result"]);
            }
            return result;
        }

        public int SaveInspectorObservation(InspectorObservation inspectorObservation)
        {
            int result = 0;
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@RegId", inspectorObservation.RegID);
            cmdParams.Add("@OffTypePlants", inspectorObservation.OffTypePlants);
            cmdParams.Add("@PestDiseaseScore", inspectorObservation.PestDiseaseScore);
            cmdParams.Add("@PlantingPattern", inspectorObservation.PlantingPattern);
            cmdParams.Add("@PollinatingFemales", inspectorObservation.PollinatingFemales);
            cmdParams.Add("@FemaleReceptiveSilks", inspectorObservation.FemaleReceptiveSilks);
            cmdParams.Add("@MaleElimination", inspectorObservation.MaleElimination);
            cmdParams.Add("@OffTypeCobs", inspectorObservation.OffTypeCobs);
            cmdParams.Add("@DefectiveCobs", inspectorObservation.DefectiveCobs);
            cmdParams.Add("@RemarksByInspector", inspectorObservation.RemarksByInspector);            
            cmdParams.Add("@RecommendationForGrower", inspectorObservation.RecommendationForGrower);
            cmdParams.Add("@DateOfSowing", inspectorObservation.DateOfSowing);
            cmdParams.Add("@CropStage", inspectorObservation.CropStage);
            cmdParams.Add("@IsIsolationDistanceMaintained", inspectorObservation.IsIsolationDistanceMaintained);
            cmdParams.Add("@GrowthCondition", inspectorObservation.GrowthCondition);
            cmdParams.Add("@RecommendationForCertification", inspectorObservation.RecommendationForCertification);
            cmdParams.Add("@Status", inspectorObservation.Status);

            DataSet ds = dbRepo.ExecuteProcedure("SaveInspectorObservation", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                result = Convert.ToInt32(ds.Tables[0].Rows[0]["Result"]);
            }
            return result;
        }

        public List<InspectorObservation> GetObservationsByUser(int mode, int userId)
        {
            List<InspectorObservation> inspObsList = new List<InspectorObservation>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@mode", mode);
            cmdParams.Add("@userId", userId);

            DataSet ds = dbRepo.ExecuteProcedure("GetObservationsByUser", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    InspectorObservation inspObs = new InspectorObservation()
                    {
                        ID = Convert.ToInt32(ds.Tables[0].Rows[i]["ObservationID"]),
                        RegID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegID"]),
                        OffTypePlants = Convert.ToString(ds.Tables[0].Rows[i]["OffTypePlants"]),
                        PestDiseaseScore = Convert.ToString(ds.Tables[0].Rows[i]["PestDiseaseScore"]),
                        PlantingPattern = Convert.ToString(ds.Tables[0].Rows[i]["PlantingPattern"]),
                        PollinatingFemales = Convert.ToString(ds.Tables[0].Rows[i]["PollinatingFemales"]),
                        FemaleReceptiveSilks = Convert.ToString(ds.Tables[0].Rows[i]["FemaleReceptiveSilks"]),
                        MaleElimination = Convert.ToString(ds.Tables[0].Rows[i]["MaleElimination"]),
                        OffTypeCobs = Convert.ToString(ds.Tables[0].Rows[i]["OffTypeCobs"]),
                        DefectiveCobs = Convert.ToString(ds.Tables[0].Rows[i]["DefectiveCobs"]),
                        RemarksByInspector = Convert.ToString(ds.Tables[0].Rows[i]["RemarksByInspector"]),
                        RecommendationForGrower = Convert.ToString(ds.Tables[0].Rows[i]["RecommendationForGrower"]),
                        Status = Convert.ToString(ds.Tables[0].Rows[i]["Status"]),
                        DateOfSowing = Convert.ToDateTime(ds.Tables[0].Rows[i]["DateOfSowing"]),
                        CropStage = Convert.ToString(ds.Tables[0].Rows[i]["CropStage"]),
                        IsIsolationDistanceMaintained = Convert.ToBoolean(ds.Tables[0].Rows[i]["IsIsolationDistanceMaintained"]),
                        GrowthCondition = Convert.ToString(ds.Tables[0].Rows[i]["GrowthCondition"]),
                        RecommendationForCertification = Convert.ToBoolean(ds.Tables[0].Rows[i]["RecommendationForCertification"]),
                        InspectionRegistration = new InspectionRegistration()
                        {
                            GrowerName = Convert.ToString(ds.Tables[0].Rows[i]["GrowerName"]),
                            InspectorName = Convert.ToString(ds.Tables[0].Rows[i]["InspectorName"]),
                            ProductCategory = new ProductCategory()
                            {
                                ProductCategoryName = Convert.ToString(ds.Tables[0].Rows[i]["ProductCategoryName"])
                            },
                            Product = new Product()
                            {
                                ProductName = Convert.ToString(ds.Tables[0].Rows[i]["ProductName"])
                            },
                            ProductClass = new ProductClass()
                            {
                                ClassName = Convert.ToString(ds.Tables[0].Rows[i]["ClassName"])
                            }
                        },
                        CreatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["CreatedAt"]),
                        CreatedBy = Convert.ToString(ds.Tables[0].Rows[i]["CreatedBy"]),
                        UpdatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["UpdatedAt"]),
                        UpdatedBy = Convert.ToString(ds.Tables[0].Rows[i]["UpdatedBy"])
                    };
                    inspObsList.Add(inspObs);
                }
            }
            return inspObsList;
        }

        public InspectorObservation GetObservationsByRegId(int regId)
        {
            InspectorObservation inspObs = new InspectorObservation();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@regId", regId);

            DataSet ds = dbRepo.ExecuteProcedure("GetObservationsByRegId", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    inspObs = new InspectorObservation()
                    {
                        ID = Convert.ToInt32(ds.Tables[0].Rows[i]["ObservationID"]),
                        RegID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegID"]),
                        OffTypePlants = Convert.ToString(ds.Tables[0].Rows[i]["OffTypePlants"]),
                        PestDiseaseScore = Convert.ToString(ds.Tables[0].Rows[i]["PestDiseaseScore"]),
                        PlantingPattern = Convert.ToString(ds.Tables[0].Rows[i]["PlantingPattern"]),
                        PollinatingFemales = Convert.ToString(ds.Tables[0].Rows[i]["PollinatingFemales"]),
                        FemaleReceptiveSilks = Convert.ToString(ds.Tables[0].Rows[i]["FemaleReceptiveSilks"]),
                        MaleElimination = Convert.ToString(ds.Tables[0].Rows[i]["MaleElimination"]),
                        OffTypeCobs = Convert.ToString(ds.Tables[0].Rows[i]["OffTypeCobs"]),
                        DefectiveCobs = Convert.ToString(ds.Tables[0].Rows[i]["DefectiveCobs"]),
                        RemarksByInspector = Convert.ToString(ds.Tables[0].Rows[i]["RemarksByInspector"]),
                        RecommendationForGrower = Convert.ToString(ds.Tables[0].Rows[i]["RecommendationForGrower"]),
                        Status = Convert.ToString(ds.Tables[0].Rows[i]["Status"]),
                        DateOfSowing = Convert.ToDateTime(ds.Tables[0].Rows[i]["DateOfSowing"]),
                        CropStage = Convert.ToString(ds.Tables[0].Rows[i]["CropStage"]),
                        IsIsolationDistanceMaintained = Convert.ToBoolean(ds.Tables[0].Rows[i]["IsIsolationDistanceMaintained"]),
                        GrowthCondition = Convert.ToString(ds.Tables[0].Rows[i]["GrowthCondition"]),
                        RecommendationForCertification = Convert.ToBoolean(ds.Tables[0].Rows[i]["RecommendationForCertification"]),
                        InspectionRegistration = new InspectionRegistration()
                        {
                            GrowerName = Convert.ToString(ds.Tables[0].Rows[i]["GrowerName"]),
                            InspectorName = Convert.ToString(ds.Tables[0].Rows[i]["InspectorName"]),
                            ProductCategory = new ProductCategory()
                            {
                                ProductCategoryName = Convert.ToString(ds.Tables[0].Rows[i]["ProductCategoryName"])
                            },
                            Product = new Product()
                            {
                                ProductName = Convert.ToString(ds.Tables[0].Rows[i]["ProductName"])
                            },
                            ProductClass = new ProductClass()
                            {
                                ClassName = Convert.ToString(ds.Tables[0].Rows[i]["ClassName"])
                            }
                        },
                        CreatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["CreatedAt"]),
                        CreatedBy = Convert.ToString(ds.Tables[0].Rows[i]["CreatedBy"]),
                        UpdatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["UpdatedAt"]),
                        UpdatedBy = Convert.ToString(ds.Tables[0].Rows[i]["UpdatedBy"])
                    };                    
                }
            }
            return inspObs;
        }
    }
}
