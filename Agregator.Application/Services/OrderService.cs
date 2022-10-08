using Agregator.Application.Common.Interfaces.OrderService;
using Agregator.Application.Common.Interfaces.Percsistence;
using Agregator.Application.Common.Models;

namespace Agregator.Application.Services;

internal class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;

    public OrderService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task PlaceOrderAsync(CreateOrderRequest orderRequest)
    {
        var user = _unitOfWork.UserRepository.Find(orderRequest.UserId);
        if (user is null)
        {
            return Task.CompletedTask;
        }
        if (user.IsBlocked)
        {
            return Task.CompletedTask;
        }

        var orderCommand = orderRequest.Map();

        _unitOfWork.OrderRepository.Add(orderCommand);
        _unitOfWork.Save();
    }
}
