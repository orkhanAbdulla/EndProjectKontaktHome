using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set;}
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public bool IsDeleted { get; set; }
        public Category Parent { get; set;}
        public List<Category> Children { get; set; }
        public List<CategoryBrand> CategoryBrands { get; set; }
        public List<CategoryFeatures> CategoryFeatures { get; set; }
        
    }
}
