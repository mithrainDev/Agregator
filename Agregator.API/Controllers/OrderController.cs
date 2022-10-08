using Agregator.Application.Common.Commands.OrderCommands;
using Agregator.Application.Common.Interfaces.OrderService;
using Agregator.Application.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agregator.API.Controllers;

[Route("Order")]
public class OrderController : BaseController
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost("PlaceOrder")]
    public async Task<IActionResult> PlaceOrderAsync(CreateOrderRequest orderRequest)
    {
        await _orderService.PlaceOrderAsync(orderRequest);
        return Ok();
    }
}
