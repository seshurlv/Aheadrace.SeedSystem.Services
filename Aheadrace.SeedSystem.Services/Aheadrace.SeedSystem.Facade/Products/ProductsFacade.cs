using Aheadrace.SeedSystem.Business.Contracts.Products;
using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Facade.Contracts.Products;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Facade.Products
{
    public class ProductsFacade : IProductsFacade
    {
        private IProductsBLL _productsBll;

        public ProductsFacade(IProductsBLL productsBll)
        {
            _productsBll = productsBll;
        }

        public List<ProductCategory> GetProductCategoryById(int id)
        {
            return _productsBll.GetProductCategoryById(id);
        }

        public List<Product> GetProductsById(int id)
        {
            return _productsBll.GetProductsById(id);
        }

        public List<Product> GetProductsByProductCategoryId(int id)
        {
            return _productsBll.GetProductsByProductCategoryId(id);
        }     
        
        public List<ProductClass> GetProductClassList(int id)
        {
            return _productsBll.GetProductClassList(id);
        }
    }
}
