using KontaktHome.DAL;
using KontaktHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Areas.ViewComponents
{
    public class LayoutViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public LayoutViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> model = _context.Categories.Where(c => c.IsMain == true && c.IsDeleted == false).Include(c => c.Children).ToList();
            return View(await Task.FromResult(model));
        }
    }
}
