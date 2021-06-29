using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string ImageUrl { get; set; }

    }
}
