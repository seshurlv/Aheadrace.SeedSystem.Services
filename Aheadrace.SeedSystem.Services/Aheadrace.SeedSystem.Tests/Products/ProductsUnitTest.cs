using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aheadrace.SeedSystem.Services.Controllers;
using Aheadrace.SeedSystem.Facade.Products;
using Aheadrace.SeedSystem.Business.Products;
using Aheadrace.SeedSystem.Repository.Products;

namespace Aheadrace.SeedSystem.Tests.Products
{
    [TestClass]
    public class ProductsUnitTest
    {
        private ProductController _productController;

        public ProductsUnitTest()
        {
            _productController = new ProductController(new ProductsFacade(new ProductsBLL(new ProductsRepository())));
        }


        [TestMethod]
        public void GetProductCategoryById()
        {
            int id = 0;
            var result = _productController.GetProductCategoryById(id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetProductsById()
        {
            int id = 0;
            var result = _productController.GetProductsById(id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetProductsByProductCategoryId()
        {
            int id = 13;
            var result = _productController.GetProductsByProductCategoryId(id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetProductClassList()
        {
            int id = 0;
            var result = _productController.GetProductClassList(id);
            Assert.IsNotNull(result);
        }
    }
}
