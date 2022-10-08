namespace Agregator.Application.Common.Commands.OrderCommands;

public record CreateOrderCommand(Guid UserId, Guid AgregatorId,
    decimal StartLatitude, decimal EndLatitude,
    decimal StartLongtitude, decimal EndLongtitude);