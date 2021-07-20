using KontaktHome.DAL;
using KontaktHome.Extensions;
using KontaktHome.Models;
using KontaktHome.ViewModels;
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
            if (categoryId == null) return NotFound();
            Category category = _context.Categories.Include(x => x.CategoryFeatures).ThenInclude(x => x.Features).FirstOrDefault(c => c.Id == categoryId);
            if (categoryId == null) return NotFound();

            ViewBag.Brands = GetAllBrandswithCatId((int)categoryId);
            ViewBag.CategoryId = categoryId;
            AdminProductVM productVM = new AdminProductVM();
            foreach (CategoryFeatures cf in category.CategoryFeatures)
            {
                productVM.Features.Add(cf.Features.Name);
            }

            return View(productVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? categoryId, AdminProductVM productVM, int? BrandId, string[] features)
        {
            if (categoryId == null) return NotFound();
            Category category = _context.Categories.Include(x => x.CategoryFeatures).ThenInclude(x => x.Features).FirstOrDefault(c => c.Id == categoryId);
            if (categoryId == null) return NotFound();
            AdminProductVM dbProductVM = new AdminProductVM();
            foreach (CategoryFeatures cf in category.CategoryFeatures)
            {
                productVM.Features.Add(cf.Features.Name);
            }
            ViewBag.Brands = GetAllBrandswithCatId((int)categoryId);
            if (!ModelState.IsValid) return View(dbProductVM);
            if (BrandId == null)
            {
                ModelState.AddModelError("", "Lütfən brend seçin");
                return View(dbProductVM);
            }
            if (productVM.Product.Photos == null)
            {
                ModelState.AddModelError("", "Lütfən şəkil seçin");
                return View(dbProductVM);
            }
            List<ProductImage> images = new List<ProductImage>();
            foreach (IFormFile photo in productVM.Product.Photos)
            {
                if (!photo.IsValidType("image/"))
                {
                    ModelState.AddModelError("", "Yalnız şəkil yükləyə bilərsiniz");
                    return View(dbProductVM);
                }
                if (!photo.IsValidSize(500))
                {
                    ModelState.AddModelError("", "Şəkilin ölçüsü 200kb çox ola bilməz");
                    return View(dbProductVM);
                }
                string folder = Path.Combine("img", "products");
                string fileName = await photo.SavaFileAsync(_env.WebRootPath, folder);
                ProductImage image = new ProductImage { Image = fileName, ProductId = productVM.Product.Id };
                images.Add(image);
            }
            if (productVM.Product.Discount == null)
            {
                productVM.Product.Discount = 0;
            }
            productVM.Product.Images = images;
            ViewBag.CategoryId = categoryId;

            int count = 0;
            List<ProductFeatures> productFeatures = new List<ProductFeatures>();
            foreach (string feature in features)
            {
                FeaturesDetail featuresDetail = new FeaturesDetail();
                featuresDetail.Description = feature;

                featuresDetail.FeaturesId=category.CategoryFeatures[count].FeaturesId;
                count++;
                ProductFeatures productFeature = new ProductFeatures();
                productFeature.FeaturesDetail = featuresDetail;
                productFeature.Product = productVM.Product;
                productFeatures.Add(productFeature);
            }

            productVM.Product.BrandId = (int)BrandId;

            await _context.ProductFeatures.AddRangeAsync(productFeatures);
            await _context.SaveChangesAsync();
            productVM.Product.Code = "A8B1C4" + productVM.Product.Id;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { categoryId });
        }
        public IActionResult LoadBrand(int? ChildCtgId)
        {

            if (ChildCtgId == null) return NotFound();
            List<CategoryBrand> CategoryBrands = _context.CategoryBrands.Where(cb => cb.CategoryId == ChildCtgId).Include(cb => cb.Brand).ToList();
            return PartialView("_CategoryBrandPartial", CategoryBrands);
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Product product = _context.Products.Include(c=>c.Brand).ThenInclude(x=>x.CategoryBrands).Include(x => x.ProductFeatures).ThenInclude(x => x.FeaturesDetail).ThenInclude(x => x.Features).FirstOrDefault(c => c.Id == id);
            if (id == null) return NotFound();
            int categoryId = product.Brand.CategoryBrands[0].CategoryId;
            ViewBag.Brands = GetAllBrandswithCatId(categoryId);
            ViewBag.Brand = product.Brand.Id;
            ViewBag.CategoryId = categoryId;
            AdminProductVM productVM = new AdminProductVM();
            productVM.Product = product;
            foreach (ProductFeatures pf in product.ProductFeatures)
            {
                productVM.Features.Add(pf.FeaturesDetail.Features.Name);
               
            }

            return View(productVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, AdminProductVM productVM, int? BrandId, string[] features)
        {
            if (id == null) return NotFound();
            Product product = _context.Products.Include(c => c.Brand).ThenInclude(x => x.CategoryBrands).Include(x => x.ProductFeatures).ThenInclude(x => x.FeaturesDetail).ThenInclude(x => x.Features).FirstOrDefault(c => c.Id == id);
            if (id == null) return NotFound();
            int categoryId = product.Brand.CategoryBrands[0].CategoryId;
            AdminProductVM dbProductVM = new AdminProductVM();
            productVM.Product = product;
            foreach (ProductFeatures pf in product.ProductFeatures)
            {
                productVM.Features.Add(pf.FeaturesDetail.Features.Name);
            }
            ViewBag.Brands = GetAllBrandswithCatId((int)categoryId);
            if (!ModelState.IsValid) return View(dbProductVM);
            if (BrandId == null)
            {
                ModelState.AddModelError("", "Lütfən brend seçin");
                return View(dbProductVM);
            }
            if (productVM.Product.Photos != null)
            {
                List<ProductImage> images = new List<ProductImage>();
                foreach (IFormFile photo in productVM.Product.Photos)
                {
                    if (!photo.IsValidType("image/"))
                    {
                        ModelState.AddModelError("", "Yalnız şəkil yükləyə bilərsiniz");
                        return View(dbProductVM);
                    }
                    if (!photo.IsValidSize(200))
                    {
                        ModelState.AddModelError("", "Şəkilin ölçüsü 200kb çox ola bilməz");
                        return View(dbProductVM);
                    }
                    string folder = Path.Combine("img", "products");
                    string fileName = await photo.SavaFileAsync(_env.WebRootPath, folder);
                    ProductImage image = new ProductImage { Image = fileName, ProductId = productVM.Product.Id };
                    images.Add(image);
                }
                productVM.Product.Images = images;
            }
           
            if (productVM.Product.Discount == null)
            {
                productVM.Product.Discount = 0;
            }
            
            ViewBag.CategoryId = categoryId;

            int count = 0;
            List<ProductFeatures> productFeatures = new List<ProductFeatures>();
            foreach (string feature in features)
            {
                product.ProductFeatures[count].FeaturesDetail.Description = feature;
                count++;
            }
            product.ProductFeatures = productFeatures;
            productVM.Product.BrandId = (int)BrandId;
            productVM.Product.Count = product.Count;
            productVM.Product.Discount = product.Discount;
            productVM.Product.Price = product.Price;
            productVM.Product.CashPrice = product.CashPrice;
            await _context.SaveChangesAsync();
            productVM.Product.Code = "A8B1C4" + productVM.Product.Id;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { categoryId });
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Product product = _context.Products.Include(x=>x.Images).FirstOrDefault(b => b.Id == id);
            if (product == null) return NotFound();
            if (!product.IsDeleted)
            {
                product.IsDeleted = true;
            }
            else
            {
                product.IsDeleted = false;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public List<Brand> GetAllBrandswithCatId(int categoryId)
        {
            List<Brand> brands = new List<Brand>();
            var categoryBrands = _context.CategoryBrands.Where(c => c.CategoryId == categoryId).Include(b => b.Brand);
            foreach (CategoryBrand cB in categoryBrands) { brands.Add(cB.Brand); }
            return brands;
        }
    }
}
