using System;
using System.Collections.Generic;
using System.Linq;

// In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.

namespace list_filtering
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
            {
                return listOfItems.OfType<int>(); 
            }
            
            List<object> MixedBag = new List<object> {5, "i", 9, 34, "h", "s"};

            GetIntegersFromList(MixedBag);
        }
    }
}
