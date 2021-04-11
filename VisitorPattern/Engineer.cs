using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Engineer: ISubscriber
    {
        public void Notify(Tuple<Shape, float> item)
        {

            switch (item.Item1)
            {
                case Square square when item.Item2 > 20.0:
                    Console.WriteLine($"Area of square with the length {square.Length} is too big.");
                    break;

                case Circle circle when item.Item2 > 30.0:
                    Console.WriteLine($"Area of circle with the radius {circle.Radius} is too big");
                    break;
                default:
                    if (item.Item2 <= 0)
                    {
                        Console.WriteLine($"Impossible Area");
                    }
                    Console.WriteLine("Seems right");
                    break;
            }
            //if (item.Item2 < 0)
            //{
            //    Console.WriteLine($"Impossible Area");
            //}
            //else if (item.Item1 is Square square)
            //{
            //    if (item.Item2 > 20.0)
            //    {
            //        Console.WriteLine($"Area of square with the length {square.Length} is too big.");
            //    }
            //} 
            //else if (item.Item1 is Circle circle)
            //{
            //    if (item.Item2 > 30.0)
            //    {
            //        Console.WriteLine($"Area of circle with the radius {circle.Radius} is too big");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Seems right");
            //}

        }
    }
}
