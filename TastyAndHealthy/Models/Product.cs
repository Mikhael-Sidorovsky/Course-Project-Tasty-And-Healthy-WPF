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
        public virtual ProductCategory Category { get; set; }
        public virtual List<DishProduct> DishProducts { get; set; }
        public virtual List<ProductBloodType> ProductBloodTypes { get; set; }
        public Product()
        {
            DishProducts = new List<DishProduct>();
            ProductBloodTypes = new List<ProductBloodType>();
        }
    }
}
