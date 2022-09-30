using Agregator.Domain.Entities;

namespace Agregator.Domain.Agregates;

public sealed class OrderAgregate
{
    public RideAgregator Agregator { get; init; } = null!;
    public User User { get; set; } = null!;
}
