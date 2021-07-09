using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        public string Title { get; set;}
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string image { get; set; }
        public bool IsDeleted { get; set; }
        public List<CategoryBrand> CategoryBrands { get; set; }
        public List<Product> Products { get; set; }

    }
}
