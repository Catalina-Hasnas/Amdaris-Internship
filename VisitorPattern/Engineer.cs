using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Engineer : ISubscriber
    {
        public void Notify((Shape, float) item)
        {
            string response = item switch
            {
                (Square square, float area) when area > 20 => $"Area of square with the length {square.Length} is too big. Area = {area}",
                (Circle circle, float area) when area > 30 => $"Area of circle with the radius {circle.Radius} is too big. Area  = {area}",
                (_, float area) when area <= 0 => "Impossible area",
                (null, _) => throw new ArgumentNullException(paramName: nameof(item), message: "Shape is null"),
                _ => "Seems right"
            };

            Console.WriteLine(response);

        }
    }
}
