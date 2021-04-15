using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade.Decorator
{
    public class RegularMilk : CondimentDecorator
    {
        public RegularMilk(Beverage beverage): base(beverage)
        {
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", milk";
        }
        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}
