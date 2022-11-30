namespace SAM_Core_App.Code;
#nullable enable

// interface as generic constraint
public class Usages3<T> where T : IUsages3<T>
{
    public void Test(T parameterT, string stringParameter = "")
    {
        var abstractMethod = T.AbstractMethod();
        T? virtualMethod = T.VirtualMethod_reabstraction(parameterT);
        parameterT = stringParameter;

        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (parameterT != null)
        {
            var localVariable = parameterT++;
            
            Console.WriteLine(localVariable);
            Console.WriteLine(parameterT.ToString());
        }
    }
}

public interface IUsages3<T> where T : IUsages3<T>
{
    static abstract T AbstractMethod();

    static virtual T? VirtualMethod_reabstraction(T? parameter)
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

interface ISam1<T> where T : ISam1<T>
{
    static abstract T operator +(T a, T b);
    static abstract implicit operator int(T t);
}

interface ISam2<T> where T : ISam2<T>
{
    static abstract T operator +(T a, T b);
    static abstract implicit operator int(T t);
}

//class Foo : ISam1<Foo>, ISam2<Foo>
//{
//    // two explicit impls delegating to one sign operator
//    static Foo ISam1<Foo>.operator +(Foo a, Foo b) => a + b;
//    static Foo ISam2<Foo>.operator +(Foo a, Foo b) => a + b;

//    public static Foo operator +(Foo a, Foo b) => a;

//    // two explicit impls delegating to one conversion operator
//    static implicit ISam1<Foo>.operator int(Foo t) => 1;
//    static implicit ISam2<Foo>.operator int(Foo t) => 2;

//    // CS0557: Duplicate user-defined conversion in type 'Foo'
//    public static implicit operator int(Foo t) => 42;
//}

public interface IDerivedUsages3<T> : IUsages3<T> where T : IDerivedUsages3<T>
{
    static T IUsages3<T>.AbstractMethod()
    {
        return default;
    }

    static abstract T? IUsages3<T>.VirtualMethod_reabstraction(T? parameter);

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

    public static DerivedUsages3? VirtualMethod_reabstraction(DerivedUsages3? parameter)
    {
        return null;
    }
}

class Usages3_1
{
    public void Test(DerivedUsages3? derivedUsages3)
    {
        DerivedUsages3.VirtualMethod_reabstraction(derivedUsages3);
    }
}