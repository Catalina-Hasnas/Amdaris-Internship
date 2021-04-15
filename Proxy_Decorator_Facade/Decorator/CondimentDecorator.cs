using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade.Decorator
{
    public abstract class CondimentDecorator: Beverage
    {
        protected Beverage beverage;
        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
    
}
