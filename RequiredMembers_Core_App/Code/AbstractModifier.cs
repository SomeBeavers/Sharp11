using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

public abstract class AbstractModifier
{
    [SetsRequiredMembers]
    protected AbstractModifier()
    {
    }

    public abstract required string Name { get; set; }
}

abstract class AbstractModifierImpl : AbstractModifier
{
    [SetsRequiredMembers]
    protected AbstractModifierImpl()
    {
    }
}

class AbstractModifierImplImpl : AbstractModifierImpl
{
    [SetsRequiredMembers]
    public AbstractModifierImplImpl()
    {
    }

    public override required string Name { get; set; }
}