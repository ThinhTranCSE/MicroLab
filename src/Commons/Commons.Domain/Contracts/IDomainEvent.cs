using MediatR;

namespace Commons.CleanArchitechture.Contracts;

public interface IDomainEvent : INotification
{
    DateTime OccurredOn { get; }
}
