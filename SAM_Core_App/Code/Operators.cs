namespace SAM_Core_App.Code;

public class Operators
{
}

public class C : IOperators<C>
{
    public static void Abstract1()
    {
    }

    public static bool operator ==(C left, C right)
    {
        return false;
    }

    public static bool operator !=(C left, C right)
    {
        return false;
    }

    public static C operator ++(C t)
    {
        return null;
    }

    public static C operator checked ++(C t)
    {
        return null;
    }
}

internal interface IOperators<T> where T : IOperators<T>
{
    static abstract void Abstract1();
    static abstract bool operator ==(T left, T right);
    static abstract bool operator !=(T left, T right);

    static abstract T operator ++(T t);
    static abstract T operator checked ++(T t);
}

interface IDerivedOperators<T>:IOperators<T> where T : IOperators<T>
{
    static bool IOperators<T>.operator ==(T left, T right)
    {
        return false;
    }

    static bool IOperators<T>.operator !=(T left, T right)
    {
        return false;
    }
}

//internal abstract class DerivedOperatorsBase
//{
//    public abstract void Abstract1();
//}

class DerivedOperators : IDerivedOperators<DerivedOperators>
{
    public static void Abstract1()
    {
    }

    public static DerivedOperators operator ++(DerivedOperators t)
    {
        return null;
    }

    public static DerivedOperators operator checked ++(DerivedOperators t)
    {
        return null;
    }
}

class Generic1<T> where T : IOperators<T>
{
    public void Test(T left, T right)
    {
        T.Abstract1();
        right = left;
        var t = left++;
        right = left;
        var derivedOperators = (t as DerivedOperators);
        DerivedOperators.Abstract1();
    }
}
