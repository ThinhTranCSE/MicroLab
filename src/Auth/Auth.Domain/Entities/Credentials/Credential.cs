using Auth.Domain.Entities.Credentials.Constants;
using Auth.Domain.Entities.Credentials.Contexts;
using Commons.CleanArchitechture.Primitives;

namespace Auth.Domain.Entities.Credentials;

public abstract class Credential : Entity
{
    public Guid AccountId { get; protected set; }
    public LoginProvider Provider { get; protected set; }
    public DateTime CreatedAt { get; protected set; }
    public CredentialStatus Status { get; protected set; }

    protected Credential() { }

    protected Credential(Guid id, Guid accountId, LoginProvider provider, DateTime createdAt)
        : base(id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException("Credential Id cannot be empty.", nameof(id));
        }

        if (accountId == Guid.Empty)
        {
            throw new ArgumentException("Account Id cannot be empty.", nameof(accountId));
        }

        Id = id;
        AccountId = accountId;
        Provider = provider;
        CreatedAt = createdAt;
        Status = CredentialStatus.Active;
    }

    public abstract bool Verify(ICredentialContext context);

    public void Revoke()
    {
        if (Status == CredentialStatus.Revoked)
        {
            throw new InvalidOperationException("Credential is already revoked.");
        }

        Status = CredentialStatus.Revoked;
    }

    public bool IsActive() => Status == CredentialStatus.Active;
}
