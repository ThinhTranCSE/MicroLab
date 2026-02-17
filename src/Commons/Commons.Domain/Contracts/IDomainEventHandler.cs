using MediatR;

namespace Commons.CleanArchitechture.Contracts;

public interface IDomainEventHandler<TDomainEvent>
    : INotificationHandler<TDomainEvent> where TDomainEvent : IDomainEvent
{
}
