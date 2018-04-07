using Aheadrace.SeedSystem.Business.Contracts.Products;
using Aheadrace.SeedSystem.Business.Products;
using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Facade.Contracts.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Facade.Products
{
    public class ProductsFacade : IProductsFacade
    {
        public List<ProductCategory> GetProductCategoryById(int id)
        {
            IProductsBLL prodBLL = new ProductsBLL();
            return prodBLL.GetProductCategoryById(id);
        }

        public List<Product> GetProductsById(int id)
        {
            IProductsBLL prodBLL = new ProductsBLL();
            return prodBLL.GetProductsById(id);
        }

        public List<Product> GetProductsByProductCategoryId(int id)
        {
            IProductsBLL prodBLL = new ProductsBLL();
            return prodBLL.GetProductsByProductCategoryId(id);
        }     
        
        public List<ProductClass> GetProductClassList(int id)
        {
            IProductsBLL prodBLL = new ProductsBLL();
            return prodBLL.GetProductClassList(id);
        }
    }
}
