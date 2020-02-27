using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TastyAndHealthy.Initializators;

namespace TastyAndHealthy.Models
{
    public class TastyAndHealthyContext : DbContext
    {
        public TastyAndHealthyContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public BloodType[] BloodTypeInitializator { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TastyAndHealthyDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodType>().HasData(BloodTypeInitializators.BloodTypesFactory());
            modelBuilder.Entity<ProductCategory>().HasData(ProductCategoryInitializator.ProductCategoriesFactory());
        }
    }
}
