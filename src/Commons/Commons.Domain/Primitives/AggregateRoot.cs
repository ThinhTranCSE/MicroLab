using Commons.CleanArchitechture.Contracts;

namespace Commons.CleanArchitechture.Primitives;

public class AggregateRoot : Entity, IAggregateRoot
{
    private readonly List<IDomainEvent> _domainEvents = [];
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    public void RaiseDomainEvent(IDomainEvent e)
    {
        throw new NotImplementedException();
    }
}
