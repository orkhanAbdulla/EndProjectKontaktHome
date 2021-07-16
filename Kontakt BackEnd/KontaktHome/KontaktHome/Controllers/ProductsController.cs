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

            List<BasketVM> basket;
            if (Request.Cookies["basket"]!=null)
            {
                basket= JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }
            BasketVM ExistPro=basket.FirstOrDefault(x => x.Id == id);
            if (ExistPro!=null)
            {
                ExistPro.Count += 1;
            }
            else
            {
                basket.Add(new BasketVM { Id = product.Id, Count = 1 });
            }
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
            return Json(basket.Count);
        }
        public async Task<IActionResult> increaseBasket(int? id)
        {
            if (id == null) return NotFound();
            Product product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();

            List<BasketVM> basket;
            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            else
            {
                basket = new List<BasketVM>();
            }
            BasketVM ExistPro = basket.FirstOrDefault(x => x.Id == id);
            if (ExistPro != null)
            {
                ExistPro.Count += 1;
            }
            else
            {
                basket.Add(new BasketVM { Id = product.Id, Count = 1 });
            }
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
            List<BasketProductVM> basketProducts = new List<BasketProductVM>();
            
                double totalPrice = 0;
                double itemsTotalPrice = 0;
                foreach (BasketVM pro in basket)
                {
                    Product DbProduct = _context.Products.Include(x => x.Images).FirstOrDefault(p => p.Id == pro.Id);
                    totalPrice = pro.Count * DbProduct.Price;
                    itemsTotalPrice += totalPrice;
                    ViewBag.ItemsTitalPrice = itemsTotalPrice;
                    basketProducts.Add(new BasketProductVM
                    {
                        Id = pro.Id,
                        Count = pro.Count,
                        Price = DbProduct.Price,
                        Name = DbProduct.Name,
                        ImageUrl = DbProduct.Images[0].Image,
                        TotalPrice = totalPrice,
                        ItemsTotalPrice = itemsTotalPrice

                    });

                }

            return PartialView("_cartBasketPartial", basketProducts);
        }
        public IActionResult decreaseBasket(int? id)
        {
            if (id == null) return NotFound();
            List<BasketVM> basket = new List<BasketVM>();
            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
                BasketVM ExistBasket = basket.FirstOrDefault(x => x.Id == id);
                if (ExistBasket.Count>0)
                {
                    ExistBasket.Count--;
                }
                else
                {
                    basket.Remove(ExistBasket);
                }
                Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
            }
            List<BasketProductVM> basketProducts = new List<BasketProductVM>();
            double totalPrice = 0;
            double itemsTotalPrice = 0;
            foreach (BasketVM pro in basket)
            {
                Product DbProduct = _context.Products.Include(x => x.Images).FirstOrDefault(p => p.Id == pro.Id);
                totalPrice = pro.Count * DbProduct.Price;
                itemsTotalPrice += totalPrice;
                ViewBag.ItemsTitalPrice = itemsTotalPrice;
                basketProducts.Add(new BasketProductVM
                {
                    Id = pro.Id,
                    Count = pro.Count,
                    Price = DbProduct.Price,
                    Name = DbProduct.Name,
                    ImageUrl = DbProduct.Images[0].Image,
                    TotalPrice = totalPrice,
                    ItemsTotalPrice = itemsTotalPrice
                });
            }

            return PartialView("_cartBasketPartial", basketProducts);

        }
        public IActionResult RemoveBasket(int id)
        {
            if (id == null) return NotFound();
            List<BasketVM> basket = new List<BasketVM>();
            if (Request.Cookies["basket"]!=null)
            {
                 basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
                BasketVM ExistBasket = basket.FirstOrDefault(x => x.Id == id);
                if (ExistBasket!=null)
                {
                    basket.Remove(ExistBasket);
                }
                Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));
            }
            List<BasketProductVM> basketProducts = new List<BasketProductVM>();
            double totalPrice = 0;
            double itemsTotalPrice = 0;
            foreach (BasketVM pro in basket)
            {
                Product DbProduct = _context.Products.Include(x => x.Images).FirstOrDefault(p => p.Id == pro.Id);
                totalPrice = pro.Count * DbProduct.Price;
                itemsTotalPrice += totalPrice;
                ViewBag.ItemsTitalPrice = itemsTotalPrice;
                basketProducts.Add(new BasketProductVM
                {
                    Id = pro.Id,
                    Count = pro.Count,
                    Price = DbProduct.Price,
                    Name = DbProduct.Name,
                    ImageUrl = DbProduct.Images[0].Image,
                    TotalPrice = totalPrice,
                    ItemsTotalPrice = itemsTotalPrice
                });
            }
          
            return PartialView("_cartBasketPartial", basketProducts);

        }
        public IActionResult AllRemoveBasket()
        {
            List<BasketVM> basket = new List<BasketVM>();
            if (Request.Cookies["basket"] != null)
            {
                Response.Cookies.Delete("basket");
            }
            List<BasketProductVM> basketProducts = new List<BasketProductVM>();
            double totalPrice = 0;
            double itemsTotalPrice = 0;
            foreach (BasketVM pro in basket)
            {
                Product DbProduct = _context.Products.Include(x => x.Images).FirstOrDefault(p => p.Id == pro.Id);
                totalPrice = pro.Count * DbProduct.Price;
                itemsTotalPrice += totalPrice;
                ViewBag.ItemsTitalPrice = itemsTotalPrice;
                basketProducts.Add(new BasketProductVM
                {
                    Id = pro.Id,
                    Count = pro.Count,
                    Price = DbProduct.Price,
                    Name = DbProduct.Name,
                    ImageUrl = DbProduct.Images[0].Image,
                    TotalPrice = totalPrice,
                    ItemsTotalPrice = itemsTotalPrice
                });
            }

            return PartialView("_cartBasketPartial", basketProducts);
           

        }
        public IActionResult Basket()
        {
            
            List<BasketProductVM> basketProducts = new List<BasketProductVM>();
            if (Request.Cookies["basket"]!=null)
            {
                List<BasketVM> basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
                double totalPrice = 0;
                double itemsTotalPrice = 0;
                foreach (BasketVM pro in basket)
                {
                    Product DbProduct = _context.Products.Include(x => x.Images).FirstOrDefault(p => p.Id == pro.Id);
                    totalPrice = pro.Count * DbProduct.Price;
                    itemsTotalPrice += totalPrice;
                    ViewBag.ItemsTitalPrice = itemsTotalPrice;
                    basketProducts.Add(new BasketProductVM
                    {
                        Id = pro.Id,
                        Count = pro.Count,
                        Price = DbProduct.Price,
                        Name = DbProduct.Name,
                        ImageUrl = DbProduct.Images[0].Image,
                        TotalPrice = totalPrice,
                        ItemsTotalPrice= itemsTotalPrice

                    });

                }

            }
       
            return View(basketProducts);
        }

    }
}
