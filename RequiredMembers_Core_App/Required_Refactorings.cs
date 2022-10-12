using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App;

public interface IRequired_Refactorings
{
    public string Name { get; set; }
}

public class Required_Refactorings : IRequired_Refactorings
{
    [SetsRequiredMembers]
    public Required_Refactorings(string name)
    {
        Name = name;
    }

    public required string Name { get; set; }
}