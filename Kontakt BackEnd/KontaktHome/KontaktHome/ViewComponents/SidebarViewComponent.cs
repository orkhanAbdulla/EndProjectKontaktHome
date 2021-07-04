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
    public class SidebarViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public SidebarViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> model = _context.Categories.Where(c=>c.IsMain==true).Include(c => c.Children).ThenInclude(cc => cc.CategoryBrands).ThenInclude(cb => cb.Brand).ToList();
            return View(await Task.FromResult(model));
        }
    }
}
