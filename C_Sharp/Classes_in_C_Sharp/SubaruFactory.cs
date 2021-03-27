using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_in_C_Sharp
{
    class SubaruFactory
    {
        // a class that creates suv object with specific subaru proprieties

        public static Suv CreateSubaruForester(int model_year, string color = "green")
        {
            if (model_year < 1997)
            {
                Console.WriteLine("Can't have a Subaru produced before 1997.");
                return null;
            }
            // if model year is valid, returns a new Suv with specific subaru proprieties
            return new Suv("subaru forester " + color, model_year, 182);
            
        }

        // here we call a method with the same name in the same class, but with different parameters
        // CreateSubaruForester is overloaded

        public static Suv CreateSubaruForester(int model_year, string special_feature, string color = "green")
        {
            if (model_year < 1997)
            {
                Console.WriteLine("Can't have a Subaru produced before 1997.");
                return null;
            }
            return new Suv("subaru forester " + color + ", " + special_feature, model_year, 182);
        }


    }
}
