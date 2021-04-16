using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade.Proxy
{
    class CafeBeaurocracy : ICafeBeaurocracy
    {
        public override void SignContracts()
        {
            Console.WriteLine("signing some contracts...");
        }
    }
}
