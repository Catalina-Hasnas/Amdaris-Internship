using System;

namespace VisitorPattern
{
    public class BlackboardDrawerVisitor : IVisitor
    {
        public void Visit(Shape shape)
        {

            switch (shape)
            {
                case Square square:
                    Console.WriteLine($"Drawing square with length {square.Length} on blackboard");
                    break;
                case Circle circle:
                    Console.WriteLine($"Drawing circle with radius {circle.Radius} on blackboard");
                    break;
                case Rectangle rectangle:
                    Console.WriteLine($"Drawing rectangle with length {rectangle.Length} and width {rectangle.Width} on blackboard");
                    break;
                default:
                    throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape));
            }
            
        }
    }
}
