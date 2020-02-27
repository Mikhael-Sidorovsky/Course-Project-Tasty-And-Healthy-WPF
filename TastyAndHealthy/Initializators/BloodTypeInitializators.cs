using System;
using System.Collections.Generic;
using System.Text;
using TastyAndHealthy.Models;

namespace TastyAndHealthy.Initializators
{
    public static class BloodTypeInitializators
    {
        public static BloodType[] BloodTypesFactory()
        {
            BloodType[] bloodTypes = new BloodType[]{ new BloodType { Id = 1, Name = "I"}, new BloodType { Id = 2, Name = "II" },
                                                      new BloodType { Id = 3, Name = "III"}, new BloodType { Id = 4, Name = "IV"}};
            return bloodTypes;
        }
    }
}
