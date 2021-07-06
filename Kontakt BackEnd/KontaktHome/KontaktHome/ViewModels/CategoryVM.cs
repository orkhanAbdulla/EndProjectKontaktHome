using KontaktHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.ViewModels
{
    public class CategoryVM
    {
        public List<Category> mainCategory { get; set; }
        public List<Category> subCategory { get; set; }

    }
}
