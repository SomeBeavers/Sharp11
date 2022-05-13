namespace CheckedOperators_Core_Lib.Resolve;

public interface IResolve2
{
}

public class Resolve2: BasicResolve2, IResolve2
{
    public static Resolve2 operator checked +(Resolve2 r2, BasicResolve2 b)
    {
        return new Resolve2();
    }

    public static Resolve2 operator +(Resolve2 r2, BasicResolve2 b)
    {
        return null;
    }
    //public static Resolve2 operator +(Resolve2 r2, Resolve2 b)
    //{
    //    return null;
    //}

    public static Resolve2 operator checked +(Resolve2 r2, IResolve2 b)
    {
        return new Resolve2();
    }

    public static Resolve2 operator +(Resolve2 r2, IResolve2 b)
    {
        return null;
    }

    public static explicit operator checked AnotherResolve(Resolve2 r)
    {
        return new AnotherResolve();
    }

    public static explicit operator AnotherResolve(Resolve2 r)
    {
        return null;
    }
}

public class AnotherResolve
{
}

public class BasicResolve2
{
}

public class UseResolve2
{
    private void Test(Resolve2 r2, BasicResolve2 b)
    {
        var r3 = checked(r2 + r2);
        checked
        {
            AnotherResolve a = (AnotherResolve)r2;
        }

        AnotherResolve a2 = (AnotherResolve)r2;
        
    }
}