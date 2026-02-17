namespace Auth.Domain.Exceptions.Credentials;

public class PasswordEmptyException : ArgumentException
{
    public PasswordEmptyException() : base("Password cannot be empty.") { }
    public PasswordEmptyException(string paramName) : base("Password cannot be empty.", paramName) { }
    public PasswordEmptyException(string message, Exception innerException) : base(message, innerException) { }
}

