using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

public ref struct Errors
{
    public required ref int t;

    [SetsRequiredMembers]
    public Errors()
    {
    }

    public static int tt = 1;
}

public class Errors2
{
    //[SetsRequiredMembers]
    public Errors2()
    {
    }

    [Obsolete]
    public required string Name { get; set; }
}

public class UseErrors
{
    public void Test()
    {
        var errors = new Errors();
        //string s = null;
    }
}