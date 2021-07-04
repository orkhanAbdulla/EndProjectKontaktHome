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
        public FeaturesDetail FeaturesDetail { get; set; }
        public List<ProductFeatures> ProductFeatures { get; set; }

    }
}
