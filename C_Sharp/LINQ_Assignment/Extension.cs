using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    public static class Extension
    {
        public static void Display<T>(this IEnumerable<T> source)
        {
            foreach (var element in source)
            {
                Console.WriteLine(element);
            }
        }
    }
}
