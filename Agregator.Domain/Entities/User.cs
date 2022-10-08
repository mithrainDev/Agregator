namespace Agregator.Domain.Entities;

public sealed class User : BaseEntity
{
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public bool IsBlocked { get; set; } = false!;
}
