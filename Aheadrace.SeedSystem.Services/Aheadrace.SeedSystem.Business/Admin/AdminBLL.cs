using Aheadrace.SeedSystem.Business.Contracts.Admin;
using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Repository.Contracts.Admin;
using System;
using System.Collections.Generic;
using System.Data;

namespace Aheadrace.SeedSystem.Business.Admin
{
    public class AdminBLL : IAdminBLL
    {
        private IAdminRepository _adminRepo;

        public AdminBLL(IAdminRepository adminRepo)
        {
            _adminRepo = adminRepo;
        }

        public int RegisterInspection(InspectionRegistration inspectionReg)
        {
            return _adminRepo.RegisterInspection(inspectionReg);
        }

        public List<InspectionRegistration> GetRegistrationsByUser(int mode, int userId)
        {
            DataSet ds = _adminRepo.GetRegistrationsByUser(mode, userId);
            List<InspectionRegistration> regList = new List<InspectionRegistration>();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (mode == 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        InspectionRegistration ir = new InspectionRegistration()
                        {
                            ID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegID"]),
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
                                ClassName = Convert.ToString(ds.Tables[0].Rows[i]["SeedClass"])
                            },
                            Status = Convert.ToString(ds.Tables[0].Rows[i]["status"]),
                            CreatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["CreatedAt"]),
                            CreatedBy = Convert.ToString(ds.Tables[0].Rows[i]["CreatedBy"]),
                            UpdatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["UpdatedAt"]),
                            UpdatedBy = Convert.ToString(ds.Tables[0].Rows[i]["UpdatedBy"])
                        };
                        regList.Add(ir);
                    }
                }
                else if (mode == 1)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        InspectionRegistration ir = new InspectionRegistration()
                        {
                            ID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegID"]),
                            GrowerName = Convert.ToString(ds.Tables[0].Rows[i]["GrowerName"]),
                            InspectorName = Convert.ToString(ds.Tables[0].Rows[i]["InspectorName"]),
                            Area = Convert.ToString(ds.Tables[0].Rows[i]["Area"]),
                            CroppingHistory = Convert.ToString(ds.Tables[0].Rows[i]["CroppingHistory"]),
                            SeedSource = Convert.ToString(ds.Tables[0].Rows[i]["SeedSource"]),                            
                            Status = Convert.ToString(ds.Tables[0].Rows[i]["status"]),
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
                                ClassName = Convert.ToString(ds.Tables[0].Rows[i]["SeedClass"])
                            },
                            User = new DataContracts.Users.User()
                            {
                                MobileNumber = Convert.ToString(ds.Tables[0].Rows[i]["MobileNumber"]),
                                Address = new DataContracts.Common.Address()
                                {
                                    AddressLine1 = Convert.ToString(ds.Tables[0].Rows[i]["Address"]),
                                    Section = new DataContracts.Common.Section()
                                    {
                                        SectionName = Convert.ToString(ds.Tables[0].Rows[i]["SectionName"])
                                    },
                                    EPA = new DataContracts.Common.EPA()
                                    {
                                        EPAName = Convert.ToString(ds.Tables[0].Rows[i]["EPA"])
                                    },
                                    District = new DataContracts.Common.District()
                                    {
                                        DistrictName = Convert.ToString(ds.Tables[0].Rows[i]["DistrictName"])
                                    },
                                    State = new DataContracts.Common.State()
                                    {
                                        StateName = Convert.ToString(ds.Tables[0].Rows[i]["StateName"])
                                    },
                                    Country = new DataContracts.Common.Country()
                                    {
                                        CountryName = Convert.ToString(ds.Tables[0].Rows[i]["CountryName"])
                                    }
                                }
                            },
                            CreatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["CreatedAt"]),
                            CreatedBy = Convert.ToString(ds.Tables[0].Rows[i]["CreatedBy"]),
                            UpdatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["UpdatedAt"]),
                            UpdatedBy = Convert.ToString(ds.Tables[0].Rows[i]["UpdatedBy"])
                        };
                        regList.Add(ir);
                    }
                }
                else if (mode == 2)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        InspectionRegistration ir = new InspectionRegistration()
                        {
                            ID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegID"]),
                            GrowerName = Convert.ToString(ds.Tables[0].Rows[i]["GrowerName"]),
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
                                ClassName = Convert.ToString(ds.Tables[0].Rows[i]["SeedClass"])
                            },
                            Status = Convert.ToString(ds.Tables[0].Rows[i]["status"]),
                            CreatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["CreatedAt"]),
                            CreatedBy = Convert.ToString(ds.Tables[0].Rows[i]["CreatedBy"]),
                            UpdatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["UpdatedAt"]),
                            UpdatedBy = Convert.ToString(ds.Tables[0].Rows[i]["UpdatedBy"])
                        };
                        regList.Add(ir);
                    }
                }
                else if (mode == 3)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        InspectionRegistration ir = new InspectionRegistration()
                        {
                            ID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegID"]),
                            GrowerName = Convert.ToString(ds.Tables[0].Rows[i]["GrowerName"]),
                            InspectorName = Convert.ToString(ds.Tables[0].Rows[i]["InspectorName"]),
                            Area = Convert.ToString(ds.Tables[0].Rows[i]["Area"]),
                            //CroppingHistory = Convert.ToString(ds.Tables[0].Rows[i]["CroppingHistory"]),
                            SeedSource = Convert.ToString(ds.Tables[0].Rows[i]["SeedSource"]),
                            Status = Convert.ToString(ds.Tables[0].Rows[i]["status"]),
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
                                ClassName = Convert.ToString(ds.Tables[0].Rows[i]["SeedClass"])
                            },
                            //User = new DataContracts.Users.User()
                            //{
                            //    MobileNumber = Convert.ToString(ds.Tables[0].Rows[i]["MobileNumber"]),
                            //    Address = new DataContracts.Common.Address()
                            //    {
                            //        AddressLine1 = Convert.ToString(ds.Tables[0].Rows[i]["Address"]),
                            //        Section = new DataContracts.Common.Section()
                            //        {
                            //            SectionName = Convert.ToString(ds.Tables[0].Rows[i]["SectionName"])
                            //        },
                            //        EPA = new DataContracts.Common.EPA()
                            //        {
                            //            EPAName = Convert.ToString(ds.Tables[0].Rows[i]["EPA"])
                            //        },
                            //        District = new DataContracts.Common.District()
                            //        {
                            //            DistrictName = Convert.ToString(ds.Tables[0].Rows[i]["DistrictName"])
                            //        },
                            //        State = new DataContracts.Common.State()
                            //        {
                            //            StateName = Convert.ToString(ds.Tables[0].Rows[i]["StateName"])
                            //        },
                            //        Country = new DataContracts.Common.Country()
                            //        {
                            //            CountryName = Convert.ToString(ds.Tables[0].Rows[i]["CountryName"])
                            //        }
                            //    }
                            //},
                            CreatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["CreatedAt"]),
                            CreatedBy = Convert.ToString(ds.Tables[0].Rows[i]["CreatedBy"]),
                            UpdatedAt = Convert.ToDateTime(ds.Tables[0].Rows[i]["UpdatedAt"]),
                            UpdatedBy = Convert.ToString(ds.Tables[0].Rows[i]["UpdatedBy"])
                        };
                        regList.Add(ir);
                    }
                }
                else
                {
                    //do nothing
                }
            }
            return regList;
        }

        public int AssignInspector(InspectionRegistration inspectionReg)
        {
            return _adminRepo.AssignInspector(inspectionReg);
        }

        public int SaveInspectorObservation(InspectorObservation inspectorObservation)
        {
            return _adminRepo.SaveInspectorObservation(inspectorObservation);
        }

        public List<InspectorObservation> GetObservationsByUser(int mode, int userId)
        {
            return _adminRepo.GetObservationsByUser(mode, userId);
        }

        public InspectorObservation GetObservationsByRegId(int regId)
        {
            return _adminRepo.GetObservationsByRegId(regId);
        }
    }
}
