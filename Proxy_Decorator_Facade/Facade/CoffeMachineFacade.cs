using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade.Facade
{
    public class CoffeMachineFacade
    {
        protected CoffeeMachine _coffeeMachine;

        public CoffeMachineFacade(CoffeeMachine coffeeMachine)
        {
            _coffeeMachine = coffeeMachine;
        }
        public void MakeCoffee()
        {
            _coffeeMachine.GetElectricity();
            _coffeeMachine.GrindCoffeeBeans();
            _coffeeMachine.HeatWater();
            _coffeeMachine.PourCoffee();
        }
    }
}
