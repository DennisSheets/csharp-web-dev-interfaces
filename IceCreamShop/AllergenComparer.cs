using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    internal class AllergenComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count < y.Allergens.Count)
            {
                return -1;
            }
            else
            {
                return 1;
            };
            //return x.Allergens.Count < y.Allergens.Count ? -1 : 1;
        }
    }
}
