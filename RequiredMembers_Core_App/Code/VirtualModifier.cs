namespace RequiredMembers_Core_App.Code;

internal class VirtualModifier
{
    //[Obsolete]
    public virtual required string Name { get; set; }
}

internal class VirtualModifierImpl : VirtualModifier
{
    public string Name2 { get; set; }
    public override required string Name { get; set; }
}

public class UseVirtualModifier
{
    public void Test()
    {
        VirtualModifierImpl virtualModifier = new()
        {
            Name2 = null,
            Name = null
        };
    }
}
