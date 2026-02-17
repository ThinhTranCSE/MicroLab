using Auth.Domain.Entities.Accounts.Constants;
using Auth.Domain.Entities.Credentials;
using Auth.Domain.Events;
using Auth.Domain.ValueObjects;
using Commons.CleanArchitechture.Primitives;

namespace Auth.Domain.Entities.Accounts;

public class Account : AggregateRoot
{
    public Username Username { get; private set; } = null!;
    public AccountStatus Status { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    private readonly List<Credential> _credentials = [];
    public IReadOnlyCollection<Credential> Credentials => _credentials.AsReadOnly();

    private Account()
    {
    }

    private Account(Guid id, Username username, AccountStatus status, DateTime createdAt)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException("Account Id cannot be empty.", nameof(id));
        }

        ArgumentNullException.ThrowIfNull(username);

        Id = id;
        Username = username;
        Status = status;
        CreatedAt = createdAt;
        RaiseDomainEvent(new AccountCreatedDomainEvent(id, username));
    }

    public static Account Create(Guid id, Username username)
    {
        return new Account(id, username, AccountStatus.PendingVerification, DateTime.UtcNow);
    }

    public static Account CreateActive(Guid id, Username username)
    {
        return new Account(id, username, AccountStatus.Active, DateTime.UtcNow);
    }

    public bool IsCanAuthenticate()
    {
        if (Status != AccountStatus.Active)
        {
            return false;
        }

        return true;
    }

    public void AddCredential(Credential credential)
    {
        ArgumentNullException.ThrowIfNull(credential);

        if (credential.AccountId != Id)
        {
            throw new InvalidOperationException("Credential does not belong to this account.");
        }

        if (_credentials.Any(c => c.Provider == credential.Provider))
        {
            throw new InvalidOperationException($"Credential with provider {credential.Provider} already exists for this account.");
        }

        _credentials.Add(credential);
        UpdatedAt = DateTime.UtcNow;

        RaiseDomainEvent(new CredentialAddedDomainEvent(Id, credential.Id, credential.Provider));
    }
}
