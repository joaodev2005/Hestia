namespace Hestia.Domain.Entities;

public abstract class EntityBase
{
    public Guid Id { get; private set; } = Guid.CreateVersion7();
    public bool Active { get; set; } = true;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}
