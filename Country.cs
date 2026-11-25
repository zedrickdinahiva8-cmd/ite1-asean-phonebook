namespace AseanPhonebook;

/// <summary>
/// Represents one ASEAN country supported by the phonebook.
/// </summary>
public class Country
{
    public string Name { get; }
    public int Code { get; }

    public Country(string name, int code)
    {
        Name = name;
        Code = code;
    }
}

/// <summary>
/// Knows every valid country. The order of the list matches the search menu:
/// [1] Philippines [2] Thailand [3] Singapore [4] Indonesia [5] Malaysia
/// </summary>
public static class CountryRegistry
{
    private static readonly List<Country> _countries = new()
    {
        new Country("Philippines", 63),
        new Country("Thailand", 66),
        new Country("Singapore", 65),
        new Country("Indonesia", 62),
        new Country("Malaysia", 60)
    };

    public static IReadOnlyList<Country> All => _countries;

    public static bool IsValidCode(int code) => _countries.Any(c => c.Code == code);

    public static Country? FindByCode(int code) => _countries.FirstOrDefault(c => c.Code == code);

    public static string DescribeValidCodes() =>
        string.Join(", ", _countries.OrderBy(c => c.Code).Select(c => $"{c.Code} ({c.Name})"));
}
