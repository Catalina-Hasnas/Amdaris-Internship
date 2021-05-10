using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Promotion: Entity<int>
    {
        public float Discount { get; set; }
        public string PromotionalText { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
