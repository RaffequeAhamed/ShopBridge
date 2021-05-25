using ShopBridge.Framework.StorageClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.DateAccess.Interface
{
   public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(int productId);
        Task<bool> UpdateProduct(Product product);
        Task<bool> AddProduct(Product product);
        Task<bool> DeleteProduct(int productId);
        Task<bool> CheckDuplicate(int id, string productName);
    }
}
