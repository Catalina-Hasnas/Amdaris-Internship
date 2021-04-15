using Proxy_Decorator_Facade.Decorator;
using System;

namespace Proxy_Decorator_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $" + beverage.Cost());


            Beverage beverage2 = new Decaf();
            beverage2 = new AlmondMilk(beverage2);
            beverage2 = new RegularMilk(beverage2);
            
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.Cost());
        }
    }
}
