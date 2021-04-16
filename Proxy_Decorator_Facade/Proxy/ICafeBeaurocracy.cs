using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade.Proxy
{
    public abstract class ICafeBeaurocracy
    {
        public abstract void SignContracts();
        public virtual void PayTaxes(string ownTaxes)
        {
            Console.WriteLine($"I need to pay my {ownTaxes}");
        }
        public virtual void PayTaxes(string ownTaxes, string companyTaxes)
        {
            Console.WriteLine($"I need to pay my {ownTaxes} and {companyTaxes}");
        }


    }
}
