using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Decorator_Facade.Proxy
{
    class CafeBeaurocracyProxy : ICafeBeaurocracy
    {
        private ICafeBeaurocracy cafeOperations;
        private Employee employee;
        public CafeBeaurocracyProxy(Employee emp)
        {
            employee = emp;
        }

        public override void SignContracts()
        {
            switch (employee.Role)
            {
                case Role.Barista:
                    Console.WriteLine("Sorry, only the manager can sign contracts.");
                    break;
                case Role.Manager:
                    cafeOperations = new CafeBeaurocracy();
                    cafeOperations.SignContracts();
                    break;
                default:
                    Console.WriteLine("Can't have acces to the contracts.");
                    break;
            }
        }

        public void HandleTaxes()
        {
            cafeOperations = new CafeBeaurocracy();

            switch (employee.Role)
            {
                case Role.Barista:
                    cafeOperations.PayTaxes("own taxes");
                    break;
                case Role.Manager:
                    cafeOperations.PayTaxes("own taxes", "company taxes");
                    break;
                default:
                    Console.WriteLine("No one can escape taxes.");
                    break;
            }
        }

    }
}
