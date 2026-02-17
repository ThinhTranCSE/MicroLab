namespace Auth.Domain.Exceptions.Accounts;

public class UsernameEmptyException : ArgumentException
{
    public UsernameEmptyException() : base("Username cannot be empty.") { }
    public UsernameEmptyException(string paramName) : base("Username cannot be empty.", paramName) { }
    public UsernameEmptyException(string message, Exception innerException) : base(message, innerException) { }
}

public class UsernameTooShortException : ArgumentException
{
    public UsernameTooShortException() : base("Username must be at least 3 characters long.") { }
    public UsernameTooShortException(string paramName) : base("Username must be at least 3 characters long.", paramName) { }
    public UsernameTooShortException(string message, Exception innerException) : base(message, innerException) { }

}

public class UsernameTooLongException : ArgumentException
{
    public UsernameTooLongException() : base("Username cannot exceed 50 characters.") { }
    public UsernameTooLongException(string paramName) : base("Username cannot exceed 50 characters.", paramName) { }
    public UsernameTooLongException(string message, Exception innerException) : base(message, innerException) { }
}