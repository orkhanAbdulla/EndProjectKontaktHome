using KontaktHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.ViewModels
{
    public class AdminProductVM
    {
        public Product Product { get; set; }
        public List<Features> Features = new List<Features>();

    }
}
