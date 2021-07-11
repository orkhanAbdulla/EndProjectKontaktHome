using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class FeaturesDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int FeaturesId { get; set; }
        public Features Features { get; set; }
        public List<ProductFeatures> ProductFeatures { get; set; }
    }
}
