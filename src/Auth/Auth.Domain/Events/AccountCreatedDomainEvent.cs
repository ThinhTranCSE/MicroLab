using Auth.Domain.ValueObjects;
using Commons.CleanArchitechture.Primitives;

namespace Auth.Domain.Events;

public sealed record AccountCreatedDomainEvent(Guid AccountId, Username Username) : DomainEvent;

