namespace Alicunde.Domain.Abstractions;

public record Error(string Code, string Name)
{
    public static Error None = new(string.Empty, string.Empty);
    public static Error NullValue = new("Error.NullValue", "Null value was provided");
    public static Error EntityNotFound = new("Error.EntityNotFound", "No entity that matches the request was found");
}