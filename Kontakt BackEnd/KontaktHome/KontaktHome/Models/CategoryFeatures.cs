using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class CategoryFeatures
    {
        public int Id { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Features Features { get; set; }
        public int FeaturesId { get; set; }
    }
}
