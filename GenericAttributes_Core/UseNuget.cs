


using Nuget;

namespace GenericAttributes_Core;

[Nuget<DerivedFromParentClass, MyStruct>]
public record UseNuget();

public class DerivedFromParentClass: ParentClass
{
}

public struct MyStruct
{
}

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
sealed class TestAttribute<T> : Attribute
{
    // See the attribute guidelines at 
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    public TestAttribute()
    {
        // TODO: Implement code here
        throw new NotImplementedException();
    }
}