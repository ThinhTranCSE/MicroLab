using Auth.Domain.Entities.Credentials.Constants;
using Commons.CleanArchitechture.Primitives;

namespace Auth.Domain.Events;

public sealed record CredentialAddedDomainEvent(Guid AccountId, Guid CredentialId, LoginProvider Provider) : DomainEvent;

