using ShopBridge.Framework.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Framework.StorageClass
{
    [Table("Product", Schema = "dbo")]
    public class Product
    {
        [Column("ProductID")]
        [Key]
        public int ProductID { get; set; }
        [Column("ProductName")]
        public string ProductName{ get; set; }
        [Column("ProductDescription")]
        public string ProductDescription { get; set; }
        [Column("ProductUnit")]
        public MeasurementUnit ProductUnit { get; set; }
        [Column("ProductPrice")]
        public decimal ProductPrice { get; set; }
        [Column("ProductQuantity")]
        public int ProductQuantity { get; set; }
        [Column("ProductStatus")]
        public ProductStatus ProductStatus { get; set; }
        [Column("ProductManufacturedDate")]
        public DateTime ProductManufacturedDate { get; set; }

    }
}
