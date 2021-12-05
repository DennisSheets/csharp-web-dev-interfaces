using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IceCreamShop
{
    internal class CostComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)

        {
            //if(x.Cost < y.Cost)
            //{
            //    return -1;
            //} 
            //else 
            //{ 
            //    return 1;
            //};

            return x.Cost < y.Cost ? -1 : 1;
        }
    }
}
