using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class AreaCalculatorVisitor : IVisitor
    {
        private List<ISubscriber> subscribers;
        public AreaCalculatorVisitor()
        {
            this.subscribers = new List<ISubscriber>();
        }
        public void AddSubscriber(ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }
        public void Visit(Shape shape)
        {
            (Shape, float) item = shape switch
            {
                Square square => (square, square.Length * square.Length),
                Circle circle => (circle, (float)(circle.Radius * circle.Radius * Math.PI)),
                Rectangle rectangle => (rectangle, rectangle.Length * rectangle.Width),
                _ => throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape))
            };
            Publish(item);
        }
        public void Publish((Shape, float) item)
        {
            this.subscribers.ForEach(s => s.Notify(item));
        }
    }
}
