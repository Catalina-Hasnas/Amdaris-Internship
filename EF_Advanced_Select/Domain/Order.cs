using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order: Entity<int>
    {
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public float TotalPrice { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
    }
}
