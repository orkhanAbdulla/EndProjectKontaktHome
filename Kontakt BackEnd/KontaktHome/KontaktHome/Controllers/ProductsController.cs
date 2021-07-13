using KontaktHome.DAL;
using KontaktHome.Models;
using KontaktHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? categoryId,int? brandId)
        {
           

            CategoryProductVM categoryProductVM = new CategoryProductVM();
            categoryProductVM.Products = new List<Product>();
            categoryProductVM.Category = new Category();
            categoryProductVM.Brand = new Brand();

            if (categoryId != null)
            {
                IQueryable<CategoryBrand> categoryBrands = _context.CategoryBrands.Where(c => c.CategoryId == categoryId).Include(x => x.Brand).ThenInclude(x => x.Products).ThenInclude(x=>x.Images);
                foreach (CategoryBrand ctB in categoryBrands)
                {
                    //Products.AddRange(ctB.Brand.Products) ;
                    categoryProductVM.Products.AddRange(ctB.Brand.Products);
                  
                }
                Category category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
                categoryProductVM.Category = category;
                ViewBag.Id = categoryId;
            }
           



            else if (brandId != null)
            {
               Brand brand = _context.Brands.Include(x=>x.Products).ThenInclude(x=>x.Images).FirstOrDefault(x => x.Id==brandId);
                categoryProductVM.Products = brand.Products;
                categoryProductVM.Brand = brand;
            }



            return View(categoryProductVM);
        }
        public IActionResult Detail(int? Id)
        {
            if (Id == null) return NotFound();
            Product products = _context.Products.Include(p => p.Images).
                Include(p => p.ProductFeatures).ThenInclude(p => p.FeaturesDetail).ThenInclude(fd=>fd.Features).FirstOrDefault(p => p.Id == Id);
            if (products == null) return NotFound();
            return View(products);
        }
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            Product product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            List<BasketVM> basket = new List<BasketVM>();
            basket.Add(new BasketVM { Id = product.Id, Count = 1 });
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Basket()
        {
            List<BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            return Json(basket);
        }
    }
}
