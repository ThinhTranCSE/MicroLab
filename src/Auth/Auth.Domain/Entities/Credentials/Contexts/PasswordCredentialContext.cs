using Auth.Domain.Entities.Credentials.Constants;
using Auth.Domain.External;

namespace Auth.Domain.Entities.Credentials.Contexts;

public class PasswordCredentialContext : ICredentialContext
{
    public ICrendentialInput Input { get; private set; }

    public LoginProvider Provider => LoginProvider.Password;

    public IPasswordHasher PasswordHasher { get; private set; }

    public PasswordCredentialContext(PasswordCredentialInput input, IPasswordHasher passwordHasher)
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        Input = input;
        ArgumentNullException.ThrowIfNull(passwordHasher, nameof(passwordHasher));
        PasswordHasher = passwordHasher;
    }
}
