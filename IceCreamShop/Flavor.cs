﻿using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    public class Flavor : Ingredient
    {
        public Flavor(string name, double cost, List<string> allergens) : base(name, cost, allergens)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
