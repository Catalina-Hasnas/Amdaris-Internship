using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class AreaCalculatorVisitor: IVisitor
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
            float area;

            switch (shape)
            {
                case Square square:
                    area = square.Length * square.Length;
                    Publish(new Tuple<Shape, float>(square, area));
                    break;
                case Circle circle:
                    area = (float)(circle.Radius * circle.Radius * Math.PI);
                    Publish(new Tuple<Shape, float>(circle, area));
                    break;
                case Rectangle rectangle:
                    area = rectangle.Length * rectangle.Width;
                    Publish(new Tuple<Shape, float>(rectangle, area));
                    break;
                default:
                    throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape));
            }

            
        }
        public void Publish(Tuple<Shape, float> item)
        {
            this.subscribers.ForEach(s => s.Notify(item));
        }


    }
}
