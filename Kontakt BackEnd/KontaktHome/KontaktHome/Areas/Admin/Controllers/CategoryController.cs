using KontaktHome.DAL;
using KontaktHome.Extensions;
using KontaktHome.Models;
using KontaktHome.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(bool isMain)
        {

            ViewBag.IsMain = isMain; 
            List<Category> categories = _context.Categories.Include(c => c.Parent).Where(c => c.IsMain == isMain).OrderByDescending(c => c.Id).ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            ViewBag.MainCtg = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category, int? MainCtgId)
        {
            ViewBag.MainCtg = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToList();
            if (!ModelState.IsValid) return View();
            if (category.IsMain==true)
            {
                bool isExist = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true)
                    .Any(c => c.Name.Trim().ToLower() == category.Name.Trim().ToLower());
                if (isExist)
                {
                    ModelState.AddModelError("Name", "Bu adda kateqoiya artıq mövcutdur");
                    return View();
                }
                if (category.Photo == null)
                {
                    ModelState.AddModelError("Photo", "Şəkil əlavə edin");
                    return View();
                }
                if (!category.Photo.IsValidType("image/"))
                {
                    ModelState.AddModelError("", "Yalnız şəkil yükləyə bilərsiniz");
                    return View();
                }
                if (!category.Photo.IsValidSize(200))
                {
                    ModelState.AddModelError("", "Şəkilin ölçüsü 200kb çox ola bilməz");
                    return View();
                }
                string folder = Path.Combine("img", "Categories");
                string fileName = await category.Photo.SavaFileAsync(_env.WebRootPath, folder);
                category.Image = fileName;
                category.IsDeleted = false;
                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Category", new { isMain = true });

            }
            else
            {
                if (MainCtgId == null)
                {
                    ModelState.AddModelError("", "Əsas Kateqoriya seçin!!!");
                }
                Category mainCategory = _context.Categories.Include(c => c.Children)
                    .FirstOrDefault(c => c.Id == MainCtgId && c.IsDeleted == false&&c.IsMain==true);
                if (mainCategory == null) return NotFound();
                bool isExist = mainCategory.Children.Any(cc => cc.Name.Trim().ToLower() == category.Name.Trim().ToLower());
                if (isExist)
                {
                    ModelState.AddModelError("Name", $"{mainCategory.Name} daxilində {category.Name} adda alt kateqoriya artıq mövcuddur!!!");
                    return View();
                }
                category.Parent = mainCategory;
                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Category", new { isMain = false });
            }
            
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Category category = _context.Categories.Include(c => c.Children).
                FirstOrDefault(c =>c.Id == id);
            if (category==null) return NotFound();

            if (!category.IsDeleted)
            {
                category.IsDeleted = true;
                if (category.Children.Count()>0)
                {
                    List<Category> children = category.Children.Where(c => c.IsDeleted == false).ToList();
                    foreach (Category ctgChild in children)
                    {
                        ctgChild.IsDeleted = true;
                    }
                }
               
            }
            else
            {
                category.IsDeleted = false;
                if (category.Children.Count() > 0)
                {
                    List<Category> children = category.Children.Where(c => c.IsDeleted == true).ToList();
                    foreach (Category ctgChild in children)
                    {
                        ctgChild.IsDeleted = false;
                    }
                }
          
            }
            await _context.SaveChangesAsync();
            if (category.IsMain)
            {
                return RedirectToAction("Index", "Category", new { isMain = true });
            }
            else
            {
                return RedirectToAction("Index", "Category", new { isMain = false });
            }


        }
        public IActionResult Update(int? id)
        {
            ViewBag.MainCtg = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToList();
            if (id == null) return NotFound();
            Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category category, int? MainCtgId)
        {
            ViewBag.MainCtg = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToList();
            if (id == null) return NotFound();
            Category categorydb = _context.Categories.Include(c => c.Parent)
                .Include(c => c.Children).FirstOrDefault(c=>c.Id== id);
            if (!ModelState.IsValid) return View(categorydb);
            if (category.IsMain == true)
            {
                bool isExist = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true)
                    .Any(c => c.Name.Trim().ToLower() == category.Name.Trim().ToLower());
                if (isExist)
                {
                    ModelState.AddModelError("Name", "Bu adda kateqoiya artıq mövcutdur");
                    return View();
                }
                if (category.Photo!=null)
                {
                    if (category.Photo == null)
                    {
                        ModelState.AddModelError("Photo", "Şəkil əlavə edin");
                        return View();
                    }
                    if (!category.Photo.IsValidType("image/"))
                    {
                        ModelState.AddModelError("", "Yalnız şəkil yükləyə bilərsiniz");
                        return View();
                    }
                    if (!category.Photo.IsValidSize(200))
                    {
                        ModelState.AddModelError("", "Şəkilin ölçüsü 200kb çox ola bilməz");
                        return View();
                    }
                    string folder = Path.Combine("img", "Categories");
                    string fileName = await category.Photo.SavaFileAsync(_env.WebRootPath, folder);
                    category.Image = fileName;
                }
                category.IsDeleted = false;
                categorydb = category;
            }
            else
            {
                if (MainCtgId == null)
                {
                    ModelState.AddModelError("", "Əsas Kateqoriya seçin!!!");
                }
                Category mainCategory = _context.Categories.Include(c => c.Children)
                    .FirstOrDefault(c => c.Id == MainCtgId && c.IsDeleted == false && c.IsMain == true);
                if (mainCategory == null) return NotFound();
                bool isExist = mainCategory.Children.Any(cc => cc.Name.Trim().ToLower() == category.Name.Trim().ToLower());
                if (isExist)
                {
                    ModelState.AddModelError("Name", $"{mainCategory.Name} daxilində {category.Name} adda alt kateqoriya artıq mövcuddur!!!");
                    return View();
                }
                category.Parent = mainCategory;
                categorydb.Parent = category.Parent;
            }
            //await _context.Categories.(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Category", new { isMain = true });
        }
        
    }
}
