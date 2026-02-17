using Auth.Domain.Entities.Credentials.Constants;
using Auth.Domain.Entities.Credentials.Contexts;
using Auth.Domain.ValueObjects;

namespace Auth.Domain.Entities.Credentials;

public class PasswordCredential : Credential
{
    public PasswordHash PasswordHash { get; private set; } = null!;

    private PasswordCredential() { }

    private PasswordCredential(Guid id, Guid accountId, PasswordHash passwordHash, DateTime createdAt)
        : base(id, accountId, LoginProvider.Password, createdAt)
    {
        PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
    }

    public static PasswordCredential Create(Guid id, Guid accountId, PasswordHash passwordHash)
    {
        return new PasswordCredential(id, accountId, passwordHash, DateTime.UtcNow);
    }

    public override bool Verify(ICredentialContext context)
    {
        if (!IsActive())
        {
            return false;
        }

        if (context is not PasswordCredentialContext passwordContext)
        {
            throw new ArgumentException("Invalid credential context for password credential.");
        }

        return passwordContext.PasswordHasher.VerifyPassword(PasswordHash, ((PasswordCredentialInput)passwordContext.Input).Password);
    }

    public void ChangePassword(PasswordHash newPasswordHash)
    {
        ArgumentNullException.ThrowIfNull(newPasswordHash);

        if (!IsActive())
        {
            throw new InvalidOperationException("Cannot change password for inactive credential.");
        }

        PasswordHash = newPasswordHash;
    }
}
