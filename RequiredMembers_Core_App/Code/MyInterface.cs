namespace RequiredMembers_Core_App.Code;

public interface MyInterface
{
    public void DefaultMethodInInterface()
    {
    }
}

internal class MyInterfaceImpl : MyInterface
{
    public required string Name { get; set; }
}

internal class Range
{
    private Location start;

    public required Location Start { get; set; }

    public required Location End { get; set; }
}

internal class Location
{
    public required int Column { get; set; }
    public required int Line { get; set; }
}

internal class UseMyInterface
{
    public void Test()
    {
        _ = new Range
        {
            Start = new()
            {
                Column = 0,
                Line = 0
            },
            End = null
        };
        _ = new Range
        {
            Start = new Location { Column = 0, Line = 0 }, End = new Location { Column = 1, Line = 0 }
        }; // Or would this form be necessary instead?
    }
}

public class C
{
    public required int Prop { get; init; }

    // Advertises that Prop is required. This is fine, because the constructor is just as accessible as the property initer.
    protected C() {}

    // Error: ctor C(object) is more accessible than required property Prop.init.
    public C(object otherArg) {}
}