using Commons.CleanArchitechture.Contracts;

namespace Commons.CleanArchitechture.Primitives;

public abstract class Entity(Guid id) : IEntity
{
    public Guid Id { get; protected set; } = id;

    protected Entity() : this(Guid.NewGuid())
    {
    }
}
