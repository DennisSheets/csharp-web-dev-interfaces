using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    public abstract class Ingredient
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public List<string> Allergens { get; set; }

        public Ingredient(string name, double cost, List<string> allergens)
        {
            Name = name;
            Cost = cost;
            Allergens = allergens;
        }

        public override string ToString()
        {
            //return "Name: " + Name + "\n" + "Cost: $" + Cost + "\n" + "Allergens: " + Allergens + "\n";

            return  $"{String.Format("{0,-18}", Name)} " +

                    $"{String.Format("${0:0.00}", Cost)}  " +   //same result as the line below
                    //$"{String.Format("{0,-6:C2} ", Cost)}  " +

                    $"  Allergens: {string.Join(" ", Allergens)}"; 
        }
    }
}
