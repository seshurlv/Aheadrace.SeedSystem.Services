using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Facade.Contracts.Products;
using Aheadrace.SeedSystem.Services.Filters;
using System.Collections.Generic;
using System.Web.Http;

namespace Aheadrace.SeedSystem.Services.Controllers
{
    [JWTAuthentication]
    public class ProductController : ApiController
    {
        private IProductsFacade _productFacade;

        public ProductController(IProductsFacade productFacade)
        {
            _productFacade = productFacade;
        }

        [HttpGet]
        public List<ProductCategory> GetProductCategoryById(int id)
        {
            return _productFacade.GetProductCategoryById(id);            
        }

        [HttpGet]
        public List<Product> GetProductsById(int id)
        {
            return _productFacade.GetProductsById(id);            
        }

        [HttpGet]
        public List<Product> GetProductsByProductCategoryId(int id)
        {
            return _productFacade.GetProductsByProductCategoryId(id);
        }

        [HttpGet]
        public List<ProductClass> GetProductClassList(int id)
        {
            return _productFacade.GetProductClassList(id);
        }
    }
}
