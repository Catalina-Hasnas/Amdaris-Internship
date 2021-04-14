using System;

namespace VisitorPattern
{
    public class BlackboardDrawerVisitor : IVisitor
    {
        public void Visit(Shape shape)
        {
            string response = shape switch
            {
                (Square square) => $"Drawing square with length {square.Length} on blackboard",
                (Circle circle) => $"Drawing circle with radius {circle.Radius} on blackboard",
                (Rectangle rectangle) => $"Drawing rectangle with length {rectangle.Length} and width {rectangle.Width} on blackboard",
                _ => throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape))
            };

            Console.WriteLine(response);
        }
    }
}
