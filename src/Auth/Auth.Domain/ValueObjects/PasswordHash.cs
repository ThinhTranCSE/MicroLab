using Auth.Domain.Exceptions.Credentials;
using Auth.Domain.External;
using Commons.CleanArchitechture.Primitives;

namespace Auth.Domain.ValueObjects;

public record PasswordHashContext(string RawPassword, IPasswordHasher PasswordHasher);

public sealed class PasswordHash : ValueObject
{
    public string Value { get; }

    private PasswordHash(string value)
    {
        Value = value;
    }

    public static PasswordHash Create(PasswordHashContext context)
    {
        if (string.IsNullOrWhiteSpace(context.RawPassword))
        {
            throw new PasswordEmptyException();
        }

        string hashedValue = context.PasswordHasher.HashPassword(context.RawPassword);

        return new PasswordHash(hashedValue);
    }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value;

    public static implicit operator string(PasswordHash passwordHash) => passwordHash.Value;
}
