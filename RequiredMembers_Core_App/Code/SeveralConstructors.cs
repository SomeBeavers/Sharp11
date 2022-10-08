using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

public class SeveralConstructors
{
    [SetsRequiredMembers]
    private SeveralConstructors(string name, string name2)
    {
        Name = name;
        Name2 = name2;
    }

    [SetsRequiredMembers]
    public SeveralConstructors() : this("Jane Doe",
        "John Doe")
    {
    }

    public required string Name { get; set; }
    public required string Name2 { get; set; }
}

class SeveralConstructorsImpl : SeveralConstructors
{
    [SetsRequiredMembers]
    private SeveralConstructorsImpl()
    {
    }

    public static SeveralConstructors Instance { get; } = new SeveralConstructorsImpl();
}

public class UseSeveralConstructors
{
    public void Test()
    {
        var severalConstructors = new SeveralConstructors();
    }
}