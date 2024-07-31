namespace Alicunde.Domain.Abstractions;

public abstract class Entity
{
    public Guid Id { get; init; }

    protected Entity(Guid guid)
    {
        Id = guid;
    }
}