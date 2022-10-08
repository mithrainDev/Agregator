using Agregator.Application.Common.Commands.OrderCommands;

namespace Agregator.Application.Common.Models;

public record CreateOrderRequest(Guid UserId,
    decimal StartLatitude, decimal EndLatitude,
    decimal StartLongtitude, decimal EndLongtitude)
{
    public CreateOrderCommand Map(Guid? id = null, 
        Guid? agregatorId = null)
    {
        return new CreateOrderCommand(
            UserId, agregatorId.Value,
            StartLatitude, EndLatitude,
            StartLongtitude, EndLongtitude);
    }
}
