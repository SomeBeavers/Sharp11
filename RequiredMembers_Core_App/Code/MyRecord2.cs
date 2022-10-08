using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

public record MyRecord2(string Name)
{
    public MyRecord2() : this("")
    {
        Name = "";
    }

    public required string Name { get; init; } = Name;

    public required InnerRecord InnerRecordProperty { get; set; }

    public record InnerRecord
    {
    }
}

public class UseMyRecord
{
    public void Test()
    {
        var myRecord2 = new MyRecord2("")
        {
            Name = null!,
            InnerRecordProperty = null!
        };

        var record2 = myRecord2 with { Name = ""};
    }
}