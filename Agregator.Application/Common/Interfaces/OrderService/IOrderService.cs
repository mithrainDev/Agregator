using Agregator.Application.Common.Models;

namespace Agregator.Application.Common.Interfaces.OrderService;

public interface IOrderService
{
    Task PlaceOrderAsync(CreateOrderRequest orderRequest);
     
}
