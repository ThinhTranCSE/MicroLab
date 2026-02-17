using Auth.Domain.Entities.Credentials.Constants;

namespace Auth.Domain.Entities.Credentials.Contexts;

public interface ICredentialContext
{
    ICrendentialInput Input { get; }
    LoginProvider Provider { get; }
}
