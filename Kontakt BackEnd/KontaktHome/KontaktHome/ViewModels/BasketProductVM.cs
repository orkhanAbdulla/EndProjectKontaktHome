using KontaktHome.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.ViewModels
{
    public class BasketProductVM
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public double? CashPrice { get; set; }
        public double? TotalPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}
