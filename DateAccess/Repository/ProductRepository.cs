using Microsoft.Extensions.Logging;
using ShopBridge.DateAccess.Interface;
using ShopBridge.Framework;
using ShopBridge.Framework.StorageClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.DateAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ILogger<ProductRepository> _logger;

        private readonly DBEntities _dbEntities;
        public ProductRepository(ILogger<ProductRepository> logger, DBEntities dbEntities)
        {
            _logger = logger;
            _dbEntities = dbEntities;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            _logger.LogInformation("Entered into GetAllProducts in ProductRepository");
            List<Product> Productlist = new List<Product>(); 
            try
            {
                Productlist = _dbEntities.Products.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting all products in GetAllProducts in ProductRepository");
            }
            return Productlist;
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            _logger.LogInformation("Entered into UpdateProducts in ProductRepository");
            bool result = false;
            try
            {
                _dbEntities.Products.Update(product);
                result = _dbEntities.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while update products in UpdateProducts in ProductRepository");
            }
            return result;
        }

        public async Task<bool> AddProduct(Product product)
        {
            _logger.LogInformation("Entered into AddProduct in ProductRepository");
            bool result = false;
            try
            {
                _dbEntities.Products.Add(product);
                result = _dbEntities.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while add products in AddProduct in ProductRepository");
            }
            return result;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            _logger.LogInformation("Entered into DeleteProduct in ProductRepository");
            bool result = false;
            try
            {
               var product = _dbEntities.Products.Where(x => x.ProductID == productId).Select(x => x).FirstOrDefault();
                if (product != null)
                {
                    _dbEntities.Remove(product);
                    result = _dbEntities.SaveChanges() > 0;
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while delete products in DeleteProduct in ProductRepository");
            }
            return result;
        }

        public async Task<bool> CheckDuplicate(int id, string productName)
        {
            _logger.LogInformation("Entered into CheckDuplicate in ProductRepository");
            bool result = false;
            try
            {

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while check duplicate products in CheckDuplicate in ProductRepository");
            }
            return result;
        }

        public async Task<Product> GetProductById(int productId)
        {
            _logger.LogInformation("Entered into GetProductById in ProductRepository");
            Product product = new Product();
            try
            {
                product = _dbEntities.Products.Where(x => x.ProductID == productId).Select(x => x).FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while get product by ID in CheckDuplicate in ProductRepository");
            }
            return product;
        }
    }
}
