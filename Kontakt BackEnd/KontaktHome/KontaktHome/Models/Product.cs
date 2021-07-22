using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public double? CashPrice { get; set; }
        public double? Discount { get; set; }
        public int Count { get; set; }
        [NotMapped]
        public IFormFile[] Photos { get; set; }
        public List<ProductImage> Images { get; set; }
        public List<ProductFeatures> ProductFeatures { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

    }
}
