using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Models
{
    public class AppUser:IdentityUser
    {
        public bool IsDeleted { get; set; }
        public Balans Balans { get; set; }
    }
}
