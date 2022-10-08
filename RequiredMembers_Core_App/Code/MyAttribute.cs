using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

//[Obsolete]
public class MyAttribute:Attribute
{
    //[Obsolete]
    [SetsRequiredMembers]
    public MyAttribute(string name)
    {
        Name = name;
    }

    [Obsolete]
    public required string Name { get; set; }
    
}

[My("")]
public class UseAttribute
{

}