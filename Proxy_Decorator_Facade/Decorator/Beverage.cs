using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade.Decorator
{
    public abstract class Beverage
    {
        public string description = "unkown beverage";
        public virtual string getDescription()
        {
            return description;
        }
        public abstract double Cost();
    }
}

