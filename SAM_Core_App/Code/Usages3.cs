namespace SAM_Core_App.Code;
#nullable enable

// interface as generic constraint
public class Usages3<T> where T : IUsages3<T>
{
    public void Test(T parameterT)
    {
    }
}

public interface IUsages3<T> where T : IUsages3<T>
{
    static abstract T AbstractMethod();

    static virtual T? VirtualMethod(T? parameter)
    {
        return parameter;
    }

    // abstract operators
    /// <summary>
    /// comment
    /// </summary>
    /// <param name="s"></param>
    static abstract implicit operator T(string s);

    // virtual operators
    static virtual T operator ++(T t)
    {
        return t;
    }
}

public interface IDerivedUsages3<T> : IUsages3<T> where T : IDerivedUsages3<T>
{
    static T IUsages3<T>.AbstractMethod()
    {
        return default;
    }

    static abstract T? IUsages3<T>.VirtualMethod(T? parameter);

    /// <summary>
    /// comment
    /// </summary>
    /// <param name="s"></param>
    static implicit IUsages3<T>.operator T(string s)
    {
        return default;
    }
}

class DerivedUsages3 : IDerivedUsages3<DerivedUsages3>
{
    public void Test()
    {

    }

    public static DerivedUsages3? VirtualMethod(DerivedUsages3? parameter)
    {
        return null;
    }
}

class Usages3_1
{
    public void Test()
    {

    }
}