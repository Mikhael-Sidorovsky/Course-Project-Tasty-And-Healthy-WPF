using System;
using System.Collections.Generic;
using System.Text;

namespace TastyAndHealthy.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public ProductCategory Category { get; set; }
        public List<DishProduct> DishProducts { get; set; }
        public List<ProductBloodType> ProductBloodTypes { get; set; }
        public Product()
        {
            DishProducts = new List<DishProduct>();
            ProductBloodTypes = new List<ProductBloodType>();
        }
    }
}
