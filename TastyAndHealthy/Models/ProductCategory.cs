using System;
using System.Collections.Generic;
using System.Text;

namespace TastyAndHealthy.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
