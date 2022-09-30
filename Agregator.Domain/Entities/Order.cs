using Agregator.Domain.Enums;

namespace Agregator.Domain.Entities;

public sealed class Order : BaseEntity
{
    public Guid UserId { get; set; } = Guid.NewGuid();
    public Guid AgregatorId { get; set; } = Guid.NewGuid();
    public OrderStatus Status { get; set; }
    public decimal StartLatitude { get; set; }
    public decimal EndLatitude { get; set; }
    public decimal StartLongtude { get; set; }
    public decimal EndLongtude { get; set; }
}
