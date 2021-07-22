using KontaktHome.DAL;
using KontaktHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class FeaturesController : Controller
    {
        private readonly AppDbContext _context;
        public FeaturesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? categoryId)
        {
            if (categoryId == null) return NotFound();
            Category category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) return NotFound();

            ViewBag.CategoryName = category.Name;
            ViewBag.CategoryId = category.Id;

            return View(GetAllFeaturesForCategoryId((int)categoryId));
        }

        public IActionResult Create(int? categoryId)
        {
            if (categoryId == null) return NotFound();
            Category category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) return NotFound();
            ViewBag.CategoryId = categoryId;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? categoryId, Features features)
        {
            if (categoryId == null) return NotFound();
            Category category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) return NotFound();

            await _context.Features.AddAsync(features);
            await _context.SaveChangesAsync();
            bool isExist = _context.Features.Any(c => c.Name.Trim().ToLower() == features.Name.Trim().ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu adda kateqoiya artıq mövcutdur");
                return View();
            }
            CategoryFeatures categoryFeatures = new CategoryFeatures
            {
                CategoryId = (int)categoryId,
                FeaturesId = features.Id
            };
            ViewBag.CategoryId = category.Id;
            await _context.CategoryFeatures.AddAsync(categoryFeatures);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { categoryId });
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Features features = _context.Features.FirstOrDefault(f => f.Id == id);
            if (features == null) return NotFound();
            return View(features);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteFeatures(int? id)
        {
            //if (categoryId == null) return NotFound();
            if (id == null) return NotFound();

            int categoryId = 0;

            var features = await _context.Features.Include(x => x.CategoryFeatures).FirstOrDefaultAsync(x => x.Id == id);
            if (features == null)
                return NotFound();

            foreach (var item in features.CategoryFeatures)
            {
                if(id == item.FeaturesId)
                {
                    _context.CategoryFeatures.Remove(item);
                    await _context.SaveChangesAsync();
                    categoryId = item.CategoryId;
                    break;
                }
            }

            return RedirectToAction(nameof(Index), new { categoryId });

        }
        public IActionResult OldFeatures(int? categoryId)
        {
            if (categoryId == null) return NotFound();
            Category category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) return NotFound();
            ViewBag.Features = _context.Features;
            ViewBag.CategoryId = category.Id;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OldFeatures(int? categoryId, List<int> featuresIds)
        {
            if (categoryId == null) return NotFound();
            Category category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) return NotFound();

            ViewBag.Features= _context.Features;

            if (featuresIds.Count() == 0)
            {
                ModelState.AddModelError("", "Ən azı bir xüsusiyyət seçin");
                return View();
            }
            foreach (int fId in featuresIds)
            {

                CategoryFeatures categoryFeatures = new CategoryFeatures
                {
                    FeaturesId = fId,
                    CategoryId = (int)categoryId,
                };
                await _context.CategoryFeatures.AddAsync(categoryFeatures);
                await _context.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index), new { categoryId });
        }
        public List<Features> GetAllFeaturesForCategoryId(int categoryId)
        {
            List<Features> features = new List<Features>();
            var categoryFeatures =  _context.CategoryFeatures.Where(c => c.CategoryId == categoryId).Include(b => b.Features);
            foreach (CategoryFeatures cB in categoryFeatures) { features.Add(cB.Features); }
            return features;
        }
    }
}
