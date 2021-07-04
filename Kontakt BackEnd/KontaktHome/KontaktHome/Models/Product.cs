using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public string Color { get; set; }
        public string Memory { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        [Required]
        public double? Price { get; set; }
        public double? CashPrice { get; set; }
        public double? Discount { get; set; }
        public int? SaleCount { get; set; }
        public int Count { get; set; }
        public List<ProductImage> Images { get; set; }
        public List<ProductFeatures> ProductFeatures { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ProductDetail ProductDetail { get; set; }

    }
}
