using Commons.CleanArchitechture.Contracts;

namespace Commons.CleanArchitechture.Primitives;

public abstract record DomainEvent : IDomainEvent
{
    public DateTime OccurredOn { get; } = DateTime.Now;
}
