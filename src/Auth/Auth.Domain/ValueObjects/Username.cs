using Auth.Domain.Exceptions.Accounts;
using Commons.CleanArchitechture.Primitives;

namespace Auth.Domain.ValueObjects;

public sealed class Username : ValueObject
{
    public string Value { get; }

    private Username(string value)
    {
        Value = value;
    }

    public static Username Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new UsernameEmptyException();
        }

        if (value.Length < 3)
        {
            throw new UsernameTooShortException();
        }

        if (value.Length > 50)
        {
            throw new UsernameTooLongException();
        }

        return new Username(value);
    }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value;

    public static implicit operator string(Username username) => username.Value;
}
