using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy_Decorator_Facade.Facade;

namespace Proxy_Decorator_Facade.Proxy
{
    public enum Role
    {
        Barista,
        Manager
    }

    public class Employee
    {
        public Role Role;
        public string Name { get; set; }
 
        public Employee(string name, Role role)
        {
            Name = name;

            Role = role;
        }

        public static void MakeCoffe(CoffeMachineFacade facade)
        {
            facade.MakeCoffee();
        }
    }
}
