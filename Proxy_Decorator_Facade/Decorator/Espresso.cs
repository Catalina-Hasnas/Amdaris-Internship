using Proxy_Decorator_Facade.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade
{
    public class Espresso: Beverage
    {
        public Espresso()
            {
                description = "Espresso";
            }
        public override double Cost()
            {
                return 1.99;
            }
    }
}
