using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.ViewModels
{
    public class UsersVM
    {
        public string id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public string Role { get; set;}
    }
}
