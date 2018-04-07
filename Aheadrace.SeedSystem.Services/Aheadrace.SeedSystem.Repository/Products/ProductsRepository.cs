using Aheadrace.SeedSystem.DataContracts.Products;
using Aheadrace.SeedSystem.Framework.Data;
using Aheadrace.SeedSystem.Repository.Contracts.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Repository.Products
{
    public class ProductsRepository : IProductRepository
    {
        DataRepository dbRepo;
        public ProductsRepository()
        {
            dbRepo = new DataRepository();
        }

        public List<ProductCategory> GetProductCategoryById(int id)
        {
            List<ProductCategory> productCategoryList = new List<ProductCategory>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@ProductCategoryID", id);

            DataSet ds = dbRepo.ExecuteProcedure("GetProductCategories", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProductCategory pc = new ProductCategory()
                    {
                        ProductCategoryID = Convert.ToInt32(ds.Tables[0].Rows[i]["ProductCategoryID"]),
                        ProductCategoryName = Convert.ToString(ds.Tables[0].Rows[i]["Name"])
                    };
                    productCategoryList.Add(pc);
                }                
            }
            return productCategoryList;
        }

        public List<Product> GetProductsById(int id)
        {
            List<Product> productList = new List<Product>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@ProductID", id);

            DataSet ds = dbRepo.ExecuteProcedure("GetProducts", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Product pc = new Product()
                    {
                        ProductID = Convert.ToInt32(ds.Tables[0].Rows[i]["ProductID"]),
                        ProductCode = Convert.ToString(ds.Tables[0].Rows[i]["ProductCode"]),
                        ProductName = Convert.ToString(ds.Tables[0].Rows[i]["Name"]),
                        ProductCategory = new ProductCategory()
                        {
                            ProductCategoryID = Convert.ToInt32(ds.Tables[0].Rows[i]["ProductCategoryID"]),
                            ProductCategoryName = Convert.ToString(ds.Tables[0].Rows[i]["ProductCategory"])
                        }
                    };
                    productList.Add(pc);
                }
            }
            return productList;
        }

        public List<Product> GetProductsByProductCategoryId(int id)
        {
            List<Product> productList = new List<Product>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@ID", id);

            DataSet ds = dbRepo.ExecuteProcedure("GetProductsByProductCategoryId", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Product pc = new Product()
                    {
                        ProductID = Convert.ToInt32(ds.Tables[0].Rows[i]["ProductID"]),
                        ProductCode = Convert.ToString(ds.Tables[0].Rows[i]["ProductCode"]),
                        ProductName = Convert.ToString(ds.Tables[0].Rows[i]["Name"]),
                        ProductCategory = new ProductCategory()
                        {
                            ProductCategoryID = Convert.ToInt32(ds.Tables[0].Rows[i]["ProductCategoryID"]),
                            ProductCategoryName = Convert.ToString(ds.Tables[0].Rows[i]["ProductCategory"])
                        }
                    };
                    productList.Add(pc);
                }
            }
            return productList;
        }

        public List<ProductClass> GetProductClassList(int id)
        {
            List<ProductClass> productClassList = new List<ProductClass>();
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@ID", id);

            DataSet ds = dbRepo.ExecuteProcedure("GetProductClass", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ProductClass pc = new ProductClass()
                    {
                        ID = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"]),
                        ClassName = Convert.ToString(ds.Tables[0].Rows[i]["ClassName"]),
                        Description = Convert.ToString(ds.Tables[0].Rows[i]["Description"])
                    };
                    productClassList.Add(pc);
                }
            }
            return productClassList;
        }
    }
}
