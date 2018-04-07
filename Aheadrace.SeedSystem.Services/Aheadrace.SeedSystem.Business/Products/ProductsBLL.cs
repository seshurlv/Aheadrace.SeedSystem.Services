using Aheadrace.SeedSystem.Business.Contracts.Products;
using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Repository.Contracts.Products;
using Aheadrace.SeedSystem.Repository.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Business.Products
{
    public class ProductsBLL : IProductsBLL
    {
        public List<ProductCategory> GetProductCategoryById(int id)
        {
            IProductRepository prodRepo = new ProductsRepository();
            return prodRepo.GetProductCategoryById(id);
        }

        public List<Product> GetProductsById(int id)
        {
            IProductRepository prodRepo = new ProductsRepository();
            return prodRepo.GetProductsById(id);
        }

        public List<Product> GetProductsByProductCategoryId(int id)
        {
            IProductRepository prodRepo = new ProductsRepository();
            return prodRepo.GetProductsByProductCategoryId(id);
        }

        public List<ProductClass> GetProductClassList(int id)
        {
            IProductRepository prodRepo = new ProductsRepository();
            return prodRepo.GetProductClassList(id);
        }
    }
}
