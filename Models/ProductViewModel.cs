using ShopBridge.Framework.Enums;
using ShopBridge.Framework.StorageClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopBridge.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; } = 0;
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; } = string.Empty;
        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; } = string.Empty;
        [Display(Name = "Product Unit")]
        [Required(AllowEmptyStrings = false)]
        public MeasurementUnit ProductUnit { get; set; }
        [Display(Name = "Product Price")]
        [Required(AllowEmptyStrings = false)]
        public decimal ProductPrice { get; set; } = 0;
        [Display(Name = "Product Quantity")]
        [Required(AllowEmptyStrings = false)]
        public int ProductQuantity { get; set; } = 0;
        [Display(Name = "Product Status")]
        [Required(AllowEmptyStrings = false)]
        public ProductStatus ProductStatus { get; set; }
        [Display(Name = "Product Manufacture date")]
        public DateTime ProductManufacturedDate { get; set; } = DateTime.Now;
        public List<Product> ProductList { get; set; }
        public string Mode { get; set; }
        public string Title { get; set; }

        public ProductViewModel BuildProductInformation(Product product_Info, string mode)
        {
            ProductID = product_Info.ProductID;
            ProductName = product_Info.ProductName;
            ProductDescription = product_Info.ProductDescription;
            ProductQuantity = product_Info.ProductQuantity;
            ProductUnit = product_Info.ProductUnit;
            ProductStatus = product_Info.ProductStatus;
            ProductPrice = product_Info.ProductPrice;
            ProductManufacturedDate = product_Info.ProductManufacturedDate;
            Mode = mode;
            return this;
        }
        public Product BuildProductInfoStorage(Product productInfo)
        {
            productInfo.ProductID = ProductID;
            productInfo.ProductName = ProductName;
            productInfo.ProductDescription = ProductDescription;
            productInfo.ProductQuantity = ProductQuantity;
            productInfo.ProductUnit = ProductUnit;
            productInfo.ProductStatus = ProductStatus;
            productInfo.ProductPrice = ProductPrice;
            productInfo.ProductManufacturedDate = ProductManufacturedDate;
            return productInfo;
        }
    }
}
