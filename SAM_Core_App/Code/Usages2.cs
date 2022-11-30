namespace SAM_Core_App.Code;

public abstract class Usages2 : IMyInterface<Usages2>, IMyInterface2<Usages2>
{
    //Usages2(int aCount)
    //{
    //}

    //public int Count { get; set; }

    //public static Usages2 operator +(Usages2 a, Usages2 b)
    //{
    //    return new Usages2(a.Count + b.Count);
    //}
    public static Usages2 Zero
    {
        get { return null; }
        set { }
    }

    static Usages2 IMyInterface<Usages2>.operator +(Usages2 a, Usages2 b)
    {
        return null;
    }

    static Usages2 IMyInterface2<Usages2>.operator +(Usages2 a, Usages2 b)
    {
        return null;
    }
}

class Usages2Impl : Usages2
{
    public static Usages2Impl Zero { get; }
}

public interface IMyInterface<T> where T : IMyInterface<T>
{
    static virtual T Zero => default;

    static abstract T operator +(T a, T b);
}

public interface IMyInterface2<T> where T : IMyInterface2<T>
{
    //static virtual T Zero => default;

    static abstract T operator +(T a, T b);
}

public interface IMyInterface3<T> : IMyInterface<T>, IMyInterface2<T> where T : IMyInterface2<T>, IMyInterface<T>
{
    static T IMyInterface<T>.Zero => default;
}

class MyInterface3 : IMyInterface3<MyInterface3>
{
    public static MyInterface3 Zero { get; }

    public static MyInterface3 /*caret*/operator +(MyInterface3 a, MyInterface3 b)
    {
        return null;
    }
}