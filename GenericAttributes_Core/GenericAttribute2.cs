namespace GenericAttributes_Core1;

//[SomeAttribute<A>]
public class GenericClass<A>
{
    //[SomeAttribute<B>]
    public void DoSomething<B>(B input) { }
}

public class SomeAttribute<C> : Attribute
{
    // `C` is either `A` or `B` according to its target.
}

public class GenericClass2<T>
{
    //[SomeAttribute(typeof(T))]
    public void DoSomething(T input)
    {
    }
}

public class SomeAttribute : Attribute
{
    public SomeAttribute(Type type)
    {
        this.Type = type;
    }

    public Type Type { get; }
}