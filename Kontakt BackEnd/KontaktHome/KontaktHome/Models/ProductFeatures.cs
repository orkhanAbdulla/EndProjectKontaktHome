using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class ProductFeatures
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int FeaturesDetailId { get; set; }
        public FeaturesDetail FeaturesDetail { get; set; }
    }
}
