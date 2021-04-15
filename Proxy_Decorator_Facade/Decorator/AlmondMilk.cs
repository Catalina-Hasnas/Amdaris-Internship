using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade.Decorator
{
    public class AlmondMilk : CondimentDecorator
    {
        public AlmondMilk(Beverage beverage) : base(beverage)
        {
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", almond milk";
        }
        public override double Cost()
        {
            return .50 + beverage.Cost();
        }
    }
}
