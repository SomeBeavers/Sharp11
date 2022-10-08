using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

internal abstract class Inheritance<T>
{
    //[SetsRequiredMembers]
    public Inheritance(List<T>  requiredBase)
    {
        // ReSharper disable once VirtualMemberCallInConstructor
        RequiredBase = requiredBase;
    }

    public virtual List<T> RequiredBase { get; set; }

    internal abstract required InnerClassInInheritance RequiredAbstractProperty
    {
        init;
    }

    internal class InnerClassInInheritance
    {

    }
}

class Derived1<T> : Inheritance<T>
{
    //[SetsRequiredMembers]
    public Derived1(List<T>  requiredBase) : base(new List<T>())
    {
    }

    public required override List<T>  RequiredBase { get; set; }

    internal override required InnerClassInInheritance RequiredAbstractProperty
    {
        init { }
    }
}

public class UseInheritance
{
    public void Test()
    {
        var derived1 = new Derived1<int>(null)
        {
            RequiredBase = new List<int>(){1,2,3},
            RequiredAbstractProperty = new Inheritance<int>.InnerClassInInheritance()
        };
    }
}