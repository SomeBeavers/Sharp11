using System.Runtime.CompilerServices;

namespace RequiredMembers_Core_App.Code;

abstract class AbstractModifier2
{
    public required MyStruct requiredField;
    internal abstract required MyStruct requiredProperty { get; init; }
}

internal abstract class AbstractModifier2Impl2 : AbstractModifier2
{
    public abstract required string Name { get; set; }
}

internal class AbstractModifier2Impl2Impl : AbstractModifier2Impl2
{
    internal override required MyStruct requiredProperty { get; init; }
    public override required string Name { get; set; }
}

class AbstractModifier2Impl : AbstractModifier2
{
    internal override required MyStruct requiredProperty { get; init; }
}

public struct MyStruct
{
    public required int fieldInStruct;
    public required MyRecord MyRecord { get; set; }
}

public record MyRecord(int required)
{
    public required int fieldInRecord;
}

public class UseAbstractModifier2
{
    public void UseTest()
    {
        var impl = Test(new AbstractModifier2Impl2Impl
        {
            requiredProperty = new()
            {
                fieldInStruct = 0,
                MyRecord = null
            },
            Name = "",
            requiredField = new()
            {
                fieldInStruct = 0,
                MyRecord = null
            }
        });
    }

    private AbstractModifier2Impl2Impl Test(AbstractModifier2Impl2Impl s)
    {
        var impl = new AbstractModifier2Impl
        {
            requiredProperty = new()
            {
                fieldInStruct = 0,
                MyRecord = new MyRecord(required: 1)
                {
                    fieldInRecord = 0
                }
            },
            requiredField = new ()
            {
                fieldInStruct = 0,
                MyRecord = new MyRecord(required: 1)
                {
                    fieldInRecord = 0
                }
            }
        };

        return null;
    }
}