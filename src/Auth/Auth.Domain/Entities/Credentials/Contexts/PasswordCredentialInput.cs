namespace Auth.Domain.Entities.Credentials.Contexts;

public class PasswordCredentialInput : ICrendentialInput
{
    public string Password { get; }
    public PasswordCredentialInput(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("Password cannot be null or empty.", nameof(password));
        }
        Password = password;
    }
}
