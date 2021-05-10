using Application.DtoModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.OrderCommands
{
    public class CreateOrderCommand : IRequest<bool>
    {
        public List<OrderItemDto> OrderItems {get; set;}
    }
}
