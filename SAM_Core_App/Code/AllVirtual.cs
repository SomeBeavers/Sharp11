using Microsoft.VisualBasic.CompilerServices;

namespace SAM_Core_App.Code;

public abstract class AllVirtual
{
    public virtual string Name
    {
        get { return null; }
        set { }
    }
}

public interface IAllVirtual<T> where T: IAllVirtual<T>, new()
{
    static virtual T Method()
    {
        return default;
    }

    public static virtual string Name
    {
        get { return null; }
        set { }
    }

    static virtual implicit operator T(string s)
    {
        return new T();
    }

    static virtual explicit operator string?(T t)
    {
        return new T().ToString();
    }

    static virtual T operator ++(T t)
    {
        return new T();
    }

    static virtual event Action E;
}

public class AllVirtual<T> : IAllVirtual<T> where T : IAllVirtual<T>, new()
{
    public static T Method()
    {
        return default;
    }

    public static string Name { get; set; }

    public static event Action? E
    {
        add { }
        remove { }
    }
}

public class Use
{
    public void Test(AllVirtual<B> parameter)
    {
        var name = AllVirtual<B>.Name;
    }
}

public class B : IAllVirtual<B>
{
}

interface I1<T> where T : I1<T>
{
    static virtual void M() {}
    static virtual T P { get; set; }
    static virtual event Action E;
    static virtual T operator +(T l, T r) { throw new NotImplementedException(); }
}