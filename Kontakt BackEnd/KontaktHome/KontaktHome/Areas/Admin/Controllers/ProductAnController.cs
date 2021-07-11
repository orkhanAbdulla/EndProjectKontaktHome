using KontaktHome.DAL;
using KontaktHome.Extensions;
using KontaktHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class ProductAnController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ProductAnController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int? categoryId)
        {
            List<Product> products = new List<Product>();
            IQueryable<CategoryBrand> categoryBrands = _context.CategoryBrands.Where(c => c.CategoryId == categoryId).Include(x => x.Brand).ThenInclude(x => x.Products).ThenInclude(x => x.Images);
            foreach (CategoryBrand ctB in categoryBrands)
            {
                products.AddRange(ctB.Brand.Products);

            }
            Category category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
            ViewBag.CategoryName = category.Name;
            ViewBag.CategoryId = category.Id;
            //List<Product> product = _context.Products.Include(p => p.Images)
            //    .Include(p=>p.Brand).ThenInclude(b=>b.CategoryBrands).ThenInclude(b=>b.Category).ToList();
            return View(products);
        }
        public IActionResult Create(int? categoryId)
        {
            List<Brand> brands = new List<Brand>();
            var categoryBrands = _context.CategoryBrands.Where(c => c.CategoryId == categoryId).Include(b=>b.Brand);
            foreach (CategoryBrand cB in categoryBrands){ brands.Add(cB.Brand); }
            ViewBag.Brands = brands;
            List<CategoryFeatures> categoryFeatures = _context.categoryFeatures.Where(cf => cf.CategoryId == categoryId).ToList();
            ViewBag.CategoryId = categoryId;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? categoryId, Product product, int? BrandId)
        {
            List<Brand> brands = new List<Brand>();
            var categoryBrands = _context.CategoryBrands.Where(c => c.CategoryId == categoryId).Include(b => b.Brand);
            foreach (CategoryBrand cB in categoryBrands) { brands.Add(cB.Brand); }
            ViewBag.Brands = brands;
            if (!ModelState.IsValid) return View();
            if (BrandId == null)
            {
                ModelState.AddModelError("", "Lütfən brend seçin");
                return View();
            }
            if (product.Photos == null)
            {
                ModelState.AddModelError("", "Lütfən şəkil seçin");
                return View();
            }
            List<ProductImage> images = new List<ProductImage>();
            foreach (IFormFile photo in product.Photos)
            {
                if (!photo.IsValidType("image/"))
                {
                    ModelState.AddModelError("", "Yalnız şəkil yükləyə bilərsiniz");
                    return View();
                }
                if (!photo.IsValidSize(200))
                {
                    ModelState.AddModelError("", "Şəkilin ölçüsü 200kb çox ola bilməz");
                    return View();
                }
                string folder = Path.Combine("img", "products");
                string fileName = await photo.SavaFileAsync(_env.WebRootPath, folder);
                ProductImage image = new ProductImage { Image = fileName,ProductId=product.Id };
                images.Add(image);
            }
            product.Images = images;

            if (product.Discount==null)
            {
                product.Discount = 0;
            }
            product.BrandId = (int)BrandId;
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            product.Code = "A8B1C4" + product.Id;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new {categoryId});
        }
        public IActionResult LoadBrand(int? ChildCtgId)
        {

            if (ChildCtgId == null) return NotFound();
            List<CategoryBrand> CategoryBrands = _context.CategoryBrands.Where(cb=>cb.CategoryId== ChildCtgId).Include(cb=>cb.Brand).ToList();
            return PartialView("_CategoryBrandPartial", CategoryBrands);
        }
       
    

    }
}
