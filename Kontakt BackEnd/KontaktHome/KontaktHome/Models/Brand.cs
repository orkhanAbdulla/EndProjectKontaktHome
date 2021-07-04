using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set;}
        public string image { get; set; }
        public List<CategoryBrand> CategoryBrands { get; set; }
        public List<Product> Products { get; set; }

    }
}
