using KontaktHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.ViewModels
{
    public class SelectProductVM
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public List<ProductFeatures> ProductFeatures { get; set; }

    }
}
