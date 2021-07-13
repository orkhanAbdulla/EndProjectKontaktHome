using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.ViewModels
{
    public class LoginVM
    {
        [Required,MaxLength(255)]
        public string UserName { get; set; }
        [Required, MaxLength(255), DataType(DataType.Password)]
        public string Password {get;set;}
        public bool RemmemberMe { get; set; }
    }
}
