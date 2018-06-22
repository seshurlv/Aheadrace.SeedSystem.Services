using Aheadrace.SeedSystem.Business.Contracts.Products;
using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Repository.Contracts.Products;
using System.Collections.Generic;

namespace Aheadrace.SeedSystem.Business.Products
{
    public class ProductsBLL : IProductsBLL
    {
        private IProductRepository _prodRepo;

        public ProductsBLL(IProductRepository prodRepo)
        {
            _prodRepo = prodRepo;
        }

        public List<ProductCategory> GetProductCategoryById(int id)
        {
            return _prodRepo.GetProductCategoryById(id);
        }

        public List<Product> GetProductsById(int id)
        {
            return _prodRepo.GetProductsById(id);
        }

        public List<Product> GetProductsByProductCategoryId(int id)
        {
            return _prodRepo.GetProductsByProductCategoryId(id);
        }

        public List<ProductClass> GetProductClassList(int id)
        {
            return _prodRepo.GetProductClassList(id);
        }
    }
}
