using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class Features
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FeaturesDetail> ProductDetails { get; set; }
        public List<CategoryFeatures> CategoryFeatures { get; set; }

    }
}
