﻿using Aheadrace.SeedSystem.DataContracts.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Facade.Contracts.Products
{
    public interface IProductsFacade
    {
        List<ProductCategory> GetProductCategoryById(int id);

        List<Product> GetProductsById(int id);

        List<Product> GetProductsByProductCategoryId(int id);

        List<ProductClass> GetProductClassList(int id);
    }
}
