using KontaktHome.DAL;
using KontaktHome.Extensions;
using KontaktHome.Helpers;
using KontaktHome.Models;
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
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BrandController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index()
        {
            List<Brand> Brand = _context.Brands.Include(b => b.CategoryBrands).ThenInclude(b=>b.Category).OrderByDescending(b =>b.Id).ToList();
            return View(Brand);
        }
        public IActionResult Create()
        {
            ViewBag.MainCtg = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToList();
            return View();
        }
        public IActionResult LoadChildCategory(int? MainCtgId)
        {
            if (MainCtgId == null) return NotFound();
          
            List<Category> categories = _context.Categories.Where(c => c.IsDeleted == false && c.Parent.Id == MainCtgId).ToList();
            return PartialView("_CategoryPartial", categories);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Brand brand,int? MainCtgId,int? ChildCtgId)
        {
            ViewBag.MainCtg = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToList();
            if (!ModelState.IsValid) return View();
            if (MainCtgId==null)
            {
                ModelState.AddModelError("", "Lütfən katiqoriya seçin");
                return View();
            }
            if (brand.Photo==null)
            {
                ModelState.AddModelError("", "Lütfən şəkil seçin");
                return View();
            }
            if (!brand.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("", "Yalnız şəkil yükləyə bilərsiniz");
                return View();
            }
            if (!brand.Photo.IsValidSize(200))
            {
                ModelState.AddModelError("", "Şəkilin ölçüsü 200kb çox ola bilməz");
                return View();
            }
            string folder = Path.Combine("img", "sidebar");
            string fileName = await brand.Photo.SavaFileAsync(_env.WebRootPath, folder);
            brand.image = fileName;
            brand.IsDeleted = false;
            List<CategoryBrand> categoryBrands = new List<CategoryBrand>();
            categoryBrands.Add(new CategoryBrand { BrandId=brand.Id,CategoryId=(int)MainCtgId });
            if (ChildCtgId!=null)
            {
                categoryBrands.Add(new CategoryBrand { BrandId = brand.Id, CategoryId = (int)ChildCtgId });
            }
            brand.CategoryBrands = categoryBrands;
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            ViewBag.MainCtg = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToList();
            if (id == null) return NotFound();
            Brand Brand = _context.Brands.Include(b => b.CategoryBrands).ThenInclude(p=>p.Category).FirstOrDefault(b=>b.Id== id);
            if (Brand == null) return NotFound();

            
            foreach (CategoryBrand cb in Brand.CategoryBrands)
            {
                if (cb.Category.IsMain)
                {
                    int MainCtgId =cb.CategoryId;
                    ViewBag.ChildCtg = _context.Categories.Where(c => c.IsDeleted == false && c.Parent.Id == MainCtgId);
                }
               
            } 
                
            return View(Brand);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Brand brand, int? MainCtgId, int? ChildCtgId)
        {
            if (id == null) return NotFound();
            Brand BrandDb = _context.Brands.Include(b => b.CategoryBrands).ThenInclude(p => p.Category).FirstOrDefault(b => b.Id == id);
            if (BrandDb == null) return NotFound();
            ViewBag.MainCtg = _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToList();
            foreach (CategoryBrand cb in BrandDb.CategoryBrands)
            {
                if (cb.Category.IsMain)
                {
                    int mainCtgId = cb.CategoryId;
                    ViewBag.ChildCtg = _context.Categories.Where(c => c.IsDeleted == false && c.Parent.Id == mainCtgId);
                }

            }
            if (MainCtgId == null)
            {
                ModelState.AddModelError("", "Lütfən katiqoriya seçin");
                return View();
            }
            if (!ModelState.IsValid) return View(BrandDb);
            if (brand.Photo != null)
            {
                if (brand.Photo == null)
                {
                    ModelState.AddModelError("Photo", "Şəkil əlavə edin");
                    return View();
                }
                if (!brand.Photo.IsValidType("image/"))
                {
                    ModelState.AddModelError("", "Yalnız şəkil yükləyə bilərsiniz");
                    return View();
                }
                if (!brand.Photo.IsValidSize(200))
                {
                    ModelState.AddModelError("", "Şəkilin ölçüsü 200kb çox ola bilməz");
                    return View();
                }
                string folder = Path.Combine("img", "sidebar");
                string fileName = await brand.Photo.SavaFileAsync(_env.WebRootPath, folder);
                BrandDb.image = fileName;
            }
            brand.IsDeleted = false;
            BrandDb.Name = brand.Name;
            BrandDb.Title = brand.Title;

            foreach (CategoryBrand cb in BrandDb.CategoryBrands)
            {
                if (cb.Category.IsMain)
                {
                    cb.CategoryId = (int)MainCtgId;
                }
                if (cb.Category.IsMain==false)
                {
                    cb.CategoryId = (int)ChildCtgId;
                }

            }
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
           Brand Brand = _context.Brands.Include(b => b.CategoryBrands).ThenInclude(p => p.Category).FirstOrDefault(b => b.Id == id);
            if (Brand == null) return NotFound();
            if (!Brand.IsDeleted)
            {
                Brand.IsDeleted = true;
            }
            else
            {
                Brand.IsDeleted = false;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }

}
