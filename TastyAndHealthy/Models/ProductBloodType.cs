using System;
using System.Collections.Generic;
using System.Text;

namespace TastyAndHealthy.Models
{
    public class ProductBloodType
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BloodTypeId { get; set; }
        public BloodType BloodType { get; set; }
    }
}
