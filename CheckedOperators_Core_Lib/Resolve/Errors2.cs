namespace CheckedOperators_Core_Lib.Resolve;
#nullable disable
public class Errors2
{
    public static implicit operator Errors3(Errors2 e)
    {
        return new Errors3();
    }

}

public class Errors3
{
}


interface I1<T> where T : I1<T>
{
    //abstract static T operator -(T x);

    //abstract static T operator checked ++(T x);
    static abstract T operator ++(T x);
    static abstract T operator --(T x);
    static abstract T operator checked --(T x);

    // ReSharper disable once OperatorWithoutMatchedCheckedOperator
    static abstract T operator /(T x, T y);
    static abstract T operator checked ++(T x);

}
class C : I1<C>
{
    public static C operator ++(C x)
    {
        return null;
    }

    public static C operator --(C x)
    {
        return null;
    }

    public static C operator checked --(C x)
    {
        return null;
    }

    public static C operator /(C x, C y)
    {
        return null;
    }

    public static C operator checked /(C x, C y)
    {
        return null;
    }

    public static C operator checked ++(C x)
    {
        return null;
    }
}