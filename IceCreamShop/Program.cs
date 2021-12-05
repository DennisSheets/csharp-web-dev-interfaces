using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;



            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            Console.WriteLine("\n\n\tFlavors: sorted by Name");
            FlavorComparer flavorComparer =  new FlavorComparer();
            availableFlavors.Sort(flavorComparer);

            foreach (Flavor flavor in availableFlavors)
            {
                Console.WriteLine(flavor );
            }



            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            Console.WriteLine("\n\n\tCones: sorted by Cost");
            CostComparer costComparer = new CostComparer();
            availableCones.Sort(costComparer);
            foreach (Cone cone in availableCones)
                {
                    Console.WriteLine(cone);
                }



            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            Console.WriteLine("\n\n\tFlavors: sorted by # of Allergens");
            AllergenComparer allergenComparer = new AllergenComparer();
            availableFlavors.Sort(allergenComparer);
            foreach (Flavor flavor in availableFlavors)
                {
                    Console.WriteLine(flavor);
                }



        }
    }

}
