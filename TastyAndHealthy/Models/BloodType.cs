using System;
using System.Collections.Generic;
using System.Text;

namespace TastyAndHealthy.Models
{
    public class BloodType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual List<ProductBloodType> ProductBloodTypes { get; set; }
        public BloodType()
        {
            ProductBloodTypes = new List<ProductBloodType>();
        }
    }
}
