using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Facade.Contracts.Products;
using Aheadrace.SeedSystem.Facade.Products;
using Aheadrace.SeedSystem.Framework.Core;
using Aheadrace.SeedSystem.Services.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aheadrace.SeedSystem.Services.Controllers
{
    [JWTAuthentication]
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<ProductCategory> GetProductCategoryById(int id)
        {
            IProductsFacade prod = new ProductsFacade();
            return prod.GetProductCategoryById(id);            
        }

        [HttpGet]
        public List<Product> GetProductsById(int id)
        {
            IProductsFacade prod = new ProductsFacade();
            return prod.GetProductsById(id);            
        }

        [HttpGet]
        public List<Product> GetProductsByProductCategoryId(int id)
        {
            IProductsFacade prod = new ProductsFacade();
            return prod.GetProductsByProductCategoryId(id);
        }

        [HttpGet]
        public List<ProductClass> GetProductClassList(int id)
        {
            IProductsFacade prod = new ProductsFacade();
            return prod.GetProductClassList(id);
        }
    }
}
