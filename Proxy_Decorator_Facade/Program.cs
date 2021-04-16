using Proxy_Decorator_Facade.Decorator;
using Proxy_Decorator_Facade.Facade;
using Proxy_Decorator_Facade.Proxy;
using System;

namespace Proxy_Decorator_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- DECORATOR ----------

            //Beverage beverage = new Espresso();
            //Console.WriteLine(beverage.getDescription() + " $" + beverage.Cost());


            //Beverage beverage2 = new Decaf();
            //beverage2 = new AlmondMilk(beverage2);
            //beverage2 = new RegularMilk(beverage2);

            //Console.WriteLine(beverage2.getDescription() + " $" + beverage2.Cost());


            // ------- PROXY -------

            //Console.WriteLine("\n\nPassing an employee with Barista Role to CafeBeaurocaryProxy");
            //Employee barista = new Employee("Sophie", Role.Barista);
            //CafeBeaurocracyProxy cafeOperationsProxy1 = new CafeBeaurocracyProxy(barista);
            //cafeOperationsProxy1.SignContracts();
            //cafeOperationsProxy1.HandleTaxes();

            //Console.WriteLine("\n\nPassing an employee with Manager Role to CafeBeaurocaryProxy");
            //Employee manager = new Employee("Laura", Role.Manager);
            //CafeBeaurocracyProxy cafeOperationsProxy2 = new CafeBeaurocracyProxy(manager);
            //cafeOperationsProxy2.SignContracts();
            //cafeOperationsProxy2.HandleTaxes();


            /// --------- FACADE --------- 

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            CoffeMachineFacade facade = new CoffeMachineFacade(coffeeMachine);
            Employee.MakeCoffe(facade);






        }
    }
}
