using KontaktHome.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Bio> Bio { get; set; }
        public DbSet<Category> Categories { get; set;}
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CategoryBrand> CategoryBrands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<ProductFeatures> ProductFeatures { get; set; }
        public DbSet<FeaturesDetail> FeaturesDetails { get; set; }
        public DbSet<CategoryFeatures> categoryFeatures { get; set; }

    }
}
