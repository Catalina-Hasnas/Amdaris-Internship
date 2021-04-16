using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade.Facade
{
    public class CoffeeMachine
    {
        public void GetElectricity()
        {
            Console.WriteLine("getting electricity...");
        }
        public void GrindCoffeeBeans()
        {
            Console.WriteLine("grinding coffee beans...");
        }
        public void HeatWater()
        {
            Console.WriteLine("heating water to the right temperature...");
        }
        public void PourCoffee()
        {
            Console.WriteLine("pouring coffee...");
        }
    }
}
