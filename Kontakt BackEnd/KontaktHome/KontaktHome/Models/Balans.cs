using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class Balans
    {
        public int Id { get; set; }
        [Required]
        public double Amount { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
    }
}
