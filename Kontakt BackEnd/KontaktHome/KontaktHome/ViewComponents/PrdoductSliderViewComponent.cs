using KontaktHome.DAL;
using KontaktHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.ViewComponents
{
    public class PrdoductSliderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public PrdoductSliderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> model = _context.Products.Where(x => x.IsDeleted == false).Include(x => x.Images).Include(x => x.ProductFeatures).OrderByDescending(x => x.Id).Take(8).ToList();
            
            return View(await Task.FromResult(model));
        }
    }
}
