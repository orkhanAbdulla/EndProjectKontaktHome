using KontaktHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.ViewModels
{
    public class CategoryProductVM
    {
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public List<Product> Products { get; set; }
    }
}
