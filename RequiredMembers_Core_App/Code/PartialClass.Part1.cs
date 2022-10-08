namespace RequiredMembers_Core_App.Code;
#nullable disable
public partial class PartialClass_Part1
{
    public PartialClass_Part1(string name, string anotherProperty)
    {
        Name1 = name;
        AnotherProperty = anotherProperty;
    }

    public required string Name1 { get; set; }

    public required string Name { get; set; }
}

public class UsePartial
{
    public void Test()
    {
        var partialClassPart1 = new PartialClass_Part1
        {
            AnotherProperty = null,
            Name = null,
            Name1 = null
        };
    }
}