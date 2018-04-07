using Aheadrace.SeedSystem.DataContracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.DataContracts.Products
{
    public class InspectionRegistration : Common.Common
    {
        public int ID { get; set; }
        public int GrowerId { get; set; }
        public int? InspectorId { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductId { get; set; }
        public string Area { get; set; }
        public DateTime PlantingDate { get; set; }
        public int SeedClassId { get; set; }
        public string SeedSource { get; set; }
        public string Certificate { get; set; }
        public string SeedLot { get; set; }
        public string CroppingHistory { get; set; }
        public string Remarks { get; set; }
        public bool SeedSourceEvidence { get; set; }
        public string GPS { get; set; }
        public string PaymentOption { get; set; }
        public string Status { get; set; }


        public User User { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public Product Product { get; set; }
        public ProductClass ProductClass { get; set; }

        public string GrowerName { get; set; }
        public string InspectorName { get; set; }
    }
}
