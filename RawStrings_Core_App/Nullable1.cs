namespace RawStrings_Core_App;

#nullable enable
public class Nullable1
{
    public string? GetString(DateTime parameter)
    {
        return $"""
{parameter}
""";
    }

}