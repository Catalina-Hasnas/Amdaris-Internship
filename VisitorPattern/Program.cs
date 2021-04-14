using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IVisitable>
            {
                new Circle(0),
                new Circle(2),
                new Square(12),
                new Circle(13),
                new Square(4),
                new Rectangle(2,4)
            };

            var andrei = new Engineer();
            
            var visitor = new AreaCalculatorVisitor();

            visitor.AddSubscriber(andrei);
            
            try
            {
                shapes.ForEach(shape => shape.Accept(visitor));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
