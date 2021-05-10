using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;
using Domain;

namespace Infrastructure.Repositories
{
    public class OrderItemsRepo : IOrderItemRepo
    {
        protected readonly ECommerceDbContext _context;
        public OrderItemsRepo(ECommerceDbContext context)
        {
            _context = context;
        }
        public void AddOrderItem(OrderItem orderItem)
        {
            _context.OrderItems.Add(orderItem);
        }
    }
}
