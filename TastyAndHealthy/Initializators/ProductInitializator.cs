﻿using System;
using System.Collections.Generic;
using System.Text;
using TastyAndHealthy.Models;

namespace TastyAndHealthy.Initializators
{
    public static class ProductInitializator
    {
        public static Product[] ProductsFactory()
        {
            BloodType[] bloodTypes = new BloodType[]{ new BloodType { Id = 1, Name = "I"}, new BloodType { Id = 2, Name = "II" },
                                                      new BloodType { Id = 3, Name = "III"}, new BloodType { Id = 4, Name = "IV"}};
            Product[] products = new Product[]
            {
                new Product{Id = 1, Name = "Rice Waffles", CategoryID = 1 },
                new Product{Id = 2, Name = "Buckwheat", CategoryID = 1 },
                new Product{Id = 3, Name = "Oatmeal pasta", CategoryID = 1 },
                new Product{Id = 4, Name = "Rye flour pasta", CategoryID = 1 },
                new Product{Id = 5, Name = "Rice flour pasta", CategoryID = 1 },
                new Product{Id = 6, Name = "Buckwheat flour", CategoryID = 1 },
                new Product{Id = 7, Name = "Oatmeal flour (oily)", CategoryID = 1 },
                new Product{Id = 8, Name = "Rye flour", CategoryID = 1 },
                new Product{Id = 9, Name = "Rye", CategoryID = 1 },
                new Product{Id = 10, Name = "Corn starch", CategoryID = 1 },
                new Product{Id = 11, Name = "Croup Kus-Kus", CategoryID = 1 },
                new Product{Id = 12, Name = "Pearl barley", CategoryID = 1 },
                new Product{Id = 13, Name = "Barley groats", CategoryID = 1 },
                new Product{Id = 14, Name = "Corn", CategoryID = 1 },
                new Product{Id = 15, Name = "Corn flour", CategoryID = 1 },
                new Product{Id = 16, Name = "Wheat flour pasta", CategoryID = 1 },
                new Product{Id = 17, Name = "Barley Pasta", CategoryID = 1 },
                new Product{Id = 18, Name = "Corn flour and grits", CategoryID = 1 },
                new Product{Id = 19, Name = "Oat bran", CategoryID = 1 },
                new Product{Id = 20, Name = "Rice bran", CategoryID = 1 },
                new Product{Id = 21, Name = "Millet", CategoryID = 1 },
                new Product{Id = 22, Name = "Rice", CategoryID = 1 },
                new Product{Id = 23, Name = "White rice", CategoryID = 1 },
                new Product{Id = 24, Name = "Brown rice", CategoryID = 1 },
                new Product{Id = 25, Name = "Processed rice", CategoryID = 1 },
                new Product{Id = 26, Name = "Cornflakes", CategoryID = 1 },
                new Product{Id = 27, Name = "Oat flakes", CategoryID = 1 },
                new Product{Id = 28, Name = "Barley", CategoryID = 1 },
                new Product{Id = 29, Name = "Wheat Bagels", CategoryID = 1 },
                new Product{Id = 30, Name = "Semolina", CategoryID = 1 },
                new Product{Id = 31, Name = "Durum wheat flour", CategoryID = 1 },
                new Product{Id = 32, Name = "Whole wheat flour", CategoryID = 1 },
                new Product{Id = 33, Name = "Muesli", CategoryID = 1 },
                new Product{Id = 34, Name = "Wheat bran", CategoryID = 1 },
                new Product{Id = 35, Name = "Wheat", CategoryID = 1 },
                new Product{Id = 36, Name = "Wheat sprouts", CategoryID = 1 },
                new Product{Id = 37, Name = "A mixture of seven grains", CategoryID = 1 },
                new Product{Id = 38, Name = "Soya Granulate", CategoryID = 1 },
                new Product{Id = 39, Name = "Soya flakes", CategoryID = 1 },
                
                new Product{Id = 40, Name = "Linseed oil", CategoryID = 2 },
                new Product{Id = 41, Name = "Olive oil", CategoryID = 2 },
                new Product{Id = 42, Name = "Cod liver oil", CategoryID = 2 },
                new Product{Id = 43, Name = "Margarine", CategoryID = 2 },
                new Product{Id = 44, Name = "Sunflower oil", CategoryID = 2 },
                new Product{Id = 45, Name = "Soybean oil", CategoryID = 2 },
                new Product{Id = 46, Name = "Fish fat", CategoryID = 2 },
                new Product{Id = 47, Name = "Peanut butter", CategoryID = 2 },
                new Product{Id = 48, Name = "Coconut oil", CategoryID = 2 },
                new Product{Id = 49, Name = "Corn oil", CategoryID = 2 },
                new Product{Id = 50, Name = "Butter", CategoryID = 2 },
                new Product{Id = 51, Name = "Sesame oil", CategoryID = 2 },

                new Product{Id = 52, Name = "Soya milk", CategoryID = 3 },
                new Product{Id = 53, Name = "Yogurt", CategoryID = 3 },
                new Product{Id = 54, Name = "Kefir", CategoryID = 3 },
                new Product{Id = 55, Name = "Goat's milk", CategoryID = 3 },
                new Product{Id = 56, Name = "Sour cream", CategoryID = 3 },
                new Product{Id = 57, Name = "Chees Feta", CategoryID = 3 },
                new Product{Id = 58, Name = "Mozzarella cheese", CategoryID = 3 },
                new Product{Id = 59, Name = "Sheep cheese", CategoryID = 3 },
                new Product{Id = 60, Name = "Brynza", CategoryID = 3 },
                new Product{Id = 61, Name = "Processed cheese", CategoryID = 3 },
                new Product{Id = 62, Name = "Cottage cheese", CategoryID = 3 },
                new Product{Id = 63, Name = "Casein", CategoryID = 3 },
                new Product{Id = 64, Name = "Skim milk", CategoryID = 3 },
                new Product{Id = 65, Name = "Whole milk", CategoryID = 3 },
                new Product{Id = 66, Name = "Milk serum", CategoryID = 3 },
                new Product{Id = 67, Name = "Ice cream", CategoryID = 3 },
                new Product{Id = 68, Name = "Buttermilk", CategoryID = 3 },
                new Product{Id = 69, Name = "Cream", CategoryID = 3 },
                new Product{Id = 70, Name = "Brie cheese", CategoryID = 3 },
                new Product{Id = 71, Name = "Dutch cheese", CategoryID = 3 },
                new Product{Id = 72, Name = "Rustic cheese", CategoryID = 3 },
                new Product{Id = 73, Name = "Cow's milk cheese", CategoryID = 3 },
                new Product{Id = 74, Name = "Camembert Cheese", CategoryID = 3 },
                new Product{Id = 75, Name = "Parmesan Cheese", CategoryID = 3 },
                new Product{Id = 76, Name = "Cheder Cheese", CategoryID = 3 },
                new Product{Id = 77, Name = "Cheese of Eden", CategoryID = 3 },
                new Product{Id = 78, Name = "Emmental cheese", CategoryID = 3 },

                new Product{Id = 79, Name = "Pink salmon", CategoryID = 4 },
                new Product{Id = 80, Name = "Carp", CategoryID = 4 },
                new Product{Id = 81, Name = "Chum", CategoryID = 4 },
                new Product{Id = 82, Name = "Salmon", CategoryID = 4 },
                new Product{Id = 83, Name = "Markel", CategoryID = 4 },
                new Product{Id = 84, Name = "Fish with white meat", CategoryID = 4 },
                new Product{Id = 85, Name = "Sardines", CategoryID = 4 },
                new Product{Id = 86, Name = "Fresh herring", CategoryID = 4 },
                new Product{Id = 87, Name = "Whitefish", CategoryID = 4 },
                new Product{Id = 88, Name = "Mackerel", CategoryID = 4 },
                new Product{Id = 89, Name = "Zander", CategoryID = 4 },
                new Product{Id = 90, Name = "Cod", CategoryID = 4 },
                new Product{Id = 91, Name = "Trout", CategoryID = 4 },
                new Product{Id = 92, Name = "Smelt", CategoryID = 4 },
                new Product{Id = 93, Name = "Seaweed", CategoryID = 4 },
                new Product{Id = 94, Name = "Sea perch", CategoryID = 4 },
                new Product{Id = 95, Name = "River perch", CategoryID = 4 },
                new Product{Id = 96, Name = "Sturgeon", CategoryID = 4 },
                new Product{Id = 97, Name = "Tuna", CategoryID = 4 },
                new Product{Id = 98, Name = "River pike", CategoryID = 4 },
                new Product{Id = 99, Name = "Catfish", CategoryID = 4 },
                new Product{Id = 100, Name = "Caviar", CategoryID = 4 },
                new Product{Id = 101, Name = "Squid", CategoryID = 4 },
                new Product{Id = 102, Name = "Flounder", CategoryID = 4 },
                new Product{Id = 103, Name = "Salmon (smoked)", CategoryID = 4 },
                new Product{Id = 104, Name = "Mollusks", CategoryID = 4 },
                new Product{Id = 105, Name = "Crabs", CategoryID = 4 },
                new Product{Id = 106, Name = "Shrimp", CategoryID = 4 },
                new Product{Id = 107, Name = "Halibut", CategoryID = 4 },
                new Product{Id = 108, Name = "Crustaceans", CategoryID = 4 },
                new Product{Id = 109, Name = "Salted herring", CategoryID = 4 },
                new Product{Id = 110, Name = "Catfish", CategoryID = 4 },
                new Product{Id = 111, Name = "Acne", CategoryID = 4 },
                new Product{Id = 112, Name = "Hake", CategoryID = 4 },

                new Product{Id = 78, Name = "Emmental cheese", CategoryID = 4 },

                new Product{Id = 79, Name = "Apple", CategoryID = 12 }
            };
            return products;
        }
    }
}
