using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace TastyAndHealthy.Models
{
    public class User
    {
        public int Id { get; set; }       
        public string Email { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public string Sex { get; set; }
        public int BloodTypeId { get; set; }
        public virtual BloodType BloodType { get; set; }
        public double CurrentWeight { get; set; }
        public double TargetWeight { get; set; }
    }
}
