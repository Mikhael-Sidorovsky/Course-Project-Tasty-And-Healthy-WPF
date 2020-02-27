using System;
using System.Collections.Generic;
using System.Text;

namespace TastyAndHealthy.Models
{
    public class DishCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; } 
    }
}
