namespace BuberDinner.Infrastructure.Authentication;

public class JwtSettings
{
    public static string SectionName = "JwtSettings";

    public string Secret { get; init; } = null!;
    public int ExpiryInMinutes { get; init; }
    public string Issuer { get; init; } = null!;
}