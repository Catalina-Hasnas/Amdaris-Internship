using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class User: Entity<int>
    {
        public string Password { get; set; }
        public string Email { get; set; }
        
    }
}
