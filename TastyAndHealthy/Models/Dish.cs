using System;
using System.Collections.Generic;
using System.Text;

namespace TastyAndHealthy.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DishProduct> DishProducts { get; set; }
        public Dish()
        {
            DishProducts = new List<DishProduct>();
        }
    }
}
