namespace Agregator.Domain.Entities;

public sealed class RideAgregator : BaseEntity
{
    public string Title { get; set; } = null!;
    public string TaxNumber { get; set; } = null!;
}
