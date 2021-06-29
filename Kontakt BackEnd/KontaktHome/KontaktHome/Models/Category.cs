using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public bool IsDeleted { get; set; }
        public Category Parent { get; set;}
        public List<Category> Children { get; set; }
    }
}
