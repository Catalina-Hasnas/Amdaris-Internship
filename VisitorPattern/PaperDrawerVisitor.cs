using System;
namespace VisitorPattern
{
    public class PaperDrawerVisitor : IVisitor
    {
        private int capacity = 30;
        public PaperDrawerVisitor(int capacity = 30)
        {
            this.capacity = capacity;
        }
        public void Visit(Shape shape)
        {
            string output = shape switch
            {
                Square square => DrawSquare(square),
                Circle circle => DrawCircle(circle),
                Rectangle rectangle => DrawRectangle(rectangle),
                _ => throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape))
            };
            Console.WriteLine(output);
        }
        private string DrawCircle(Circle circle)
        {
            int diameter = 2 * circle.Radius;
            if (capacity - diameter < 0)
            {
                ShowError();
                throw new InvalidOperationException($"Current capacity {capacity} but tried to draw circle of diameter {diameter}");
            }
            capacity -= diameter;
            return $"Drawing circle with radius {circle.Radius} on paper";
        }
        private string DrawSquare(Square square)
        {
            if (capacity - square.Length < 0)
            {
                ShowError();
                throw new InvalidOperationException($"Current capacity {capacity} but tried to draw square of length {square.Length}");
            }
            capacity -= square.Length;
            return $"Drawing square with length {square.Length} on paper";
        }
        private string DrawRectangle(Rectangle rectangle)
        {
            if (capacity - rectangle.Length < 0)
            {
                ShowError();
                throw new InvalidOperationException($"Current capacity {capacity} but tried to draw square of length {rectangle.Length} and width {rectangle.Width}");
            }
            capacity -= rectangle.Length;
            return $"Drawing square with length {rectangle.Length} and width {rectangle.Width} on paper";
        }
        private static void ShowError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Max capacity reached");
            Console.ResetColor();
        }
    }
}