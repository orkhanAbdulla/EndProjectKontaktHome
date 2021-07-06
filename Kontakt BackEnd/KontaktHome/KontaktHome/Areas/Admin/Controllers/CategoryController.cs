using KontaktHome.DAL;
using KontaktHome.Models;
using KontaktHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? MainCtg,int? SubCtg)
        {
            CategoryVM categoryVM = new CategoryVM();

            if (MainCtg!=null)
            {
                categoryVM.mainCategory = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).OrderByDescending(c => c.Id).ToList();
            }
            if (SubCtg!= null)
            {
                categoryVM.subCategory = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == false).OrderByDescending(c => c.Id).ToList();
            }

            return View(categoryVM);
        }
        public IActionResult Create()
        {
            ViewBag.MainCtg = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category, int MainCtgId)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
