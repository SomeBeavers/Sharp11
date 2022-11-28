namespace SAM_Core_App.Code;

public abstract class AllAbstract
{
    int t;
    public abstract string Name { get; set; }
}

internal interface IAbstractAllMembersInterface<T> where T : IAbstractAllMembersInterface<T>
{
    public static abstract T Property { get; set; }
    static abstract T AbstractMethod(List<T> list);

    static abstract implicit operator T(string s);
    public static abstract explicit operator string /*caret*/(T t);

    static abstract T operator ++(T t);
    static abstract event Action<T> Action;
}


interface IDerivedInterface: IAbstractAllMembersInterface<IDerivedInterface>
{
    static IDerivedInterface IAbstractAllMembersInterface<IDerivedInterface>.Property
    {
        get => null;
        set { }
    }

    static IDerivedInterface IAbstractAllMembersInterface<IDerivedInterface>.AbstractMethod(List<IDerivedInterface> list)
    {
        return null;
    }

    static implicit IAbstractAllMembersInterface<IDerivedInterface>.operator IDerivedInterface(string s)
    {
        return null;
    }

    static explicit IAbstractAllMembersInterface<IDerivedInterface>.operator string(IDerivedInterface t)
    {
        return null;
    }

    static IDerivedInterface IAbstractAllMembersInterface<IDerivedInterface>.operator ++(IDerivedInterface t)
    {
        return null;
    }

    static event Action<IDerivedInterface>? IAbstractAllMembersInterface<IDerivedInterface>.Action
    {
        add { }
        remove { }
    }
}

class DerivedInterface : IDerivedInterface
{
}

class AbstractAllMembersInterface : IAbstractAllMembersInterface<AbstractAllMembersInterface>
{
    public static AbstractAllMembersInterface Property { get; set; }
    public static AbstractAllMembersInterface AbstractMethod(List<AbstractAllMembersInterface> list)
    {
        return null;
    }

    public static implicit operator AbstractAllMembersInterface(string s)
    {
        return null;
    }

    public static explicit operator string(AbstractAllMembersInterface t)
    {
        return null;
    }

    public static AbstractAllMembersInterface operator ++(AbstractAllMembersInterface t)
    {
        return null;
    }

    public static event Action<AbstractAllMembersInterface>? Action;
}

internal class A : IAbstractAllMembersInterface<A>
{
    public static A Property { get; set; }
    public static A AbstractMethod(List<A> list)
    {
        return null;
    }

    public static implicit operator A(string s)
    {
        return null;
    }

    public static explicit operator string(A t)
    {
        return null;
    }

    public static A operator ++(A t)
    {
        return null;
    }

    public static event Action<A>? Action;
}

internal interface I<T> where T : I<T>
{
    static abstract T P { get; set; }
    static abstract void M();
    static abstract event Action E;
    static abstract T operator +(T l, T r);
    static abstract bool operator ==(T l, T r);
    static abstract bool operator !=(T l, T r);
    static abstract implicit operator T(string s);
    static abstract explicit operator string(T t);
}