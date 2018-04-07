using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aheadrace.SeedSystem.DataContracts.Common;

namespace Aheadrace.SeedSystem.DataContracts.Products
{
    public class Product : Common.Common
    {
        public int ProductID { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public ProductCategory ProductCategory { get; set; }
    }

    public class ProductCategory : Common.Common
    {
        public int ProductCategoryID { get; set; }

        public string ProductCategoryName { get; set; }

        public string Description { get; set; }                
    }

    public class ProductClass : Common.Common
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
    }


}
