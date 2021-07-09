using KontaktHome.DAL;
using KontaktHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductAnController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductAnController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Product> product = _context.Products.Include(p => p.Images).Include(p => p.ProductDetail)
                .Include(p=>p.Brand).ThenInclude(b=>b.CategoryBrands).ThenInclude(b=>b.Category).ToList();
            return View(product);
        }
    }
}
