using System;
using System.Collections.Generic;
using System.Text;
using TastyAndHealthy.Models;

namespace TastyAndHealthy.Initializators
{
    public static class ProductCategoryInitializator
    {
        public static ProductCategory[] ProductCategoriesFactory()
        {
            ProductCategory[] categories = new ProductCategory[]
            {
                new ProductCategory{Id = 1, Name = "Grains, cereals and pasta"},
                new ProductCategory{Id = 2, Name = "Oils and fats"},
                new ProductCategory{Id = 3, Name = "Dairy"},
                new ProductCategory{Id = 4, Name = "Seafood and fish"},
                new ProductCategory{Id = 5, Name = "Meat and poultry"},
                new ProductCategory{Id = 6, Name = "Vegetables and mushrooms"},
                new ProductCategory{Id = 7, Name = "Nuts and seeds"},
                new ProductCategory{Id = 8, Name = "Legumes"},
                new ProductCategory{Id = 9, Name = "Other drinks"},
                new ProductCategory{Id = 10, Name = "Spices"},
                new ProductCategory{Id = 11, Name = "Herbal teas"},
                new ProductCategory{Id = 12, Name = "Fruits and berries"},
                new ProductCategory{Id = 13, Name = "Bread and Muffin"},
                new ProductCategory{Id = 14, Name = "Juices"}
            };
            return categories;
        }
    }
}
