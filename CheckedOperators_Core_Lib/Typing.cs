namespace CheckedOperators_Core_Lib;
#nullable disable
public class Typing
{
    public string Name { get; set; }

    public static Typing operator checked ++(Typing c)
    {
        return null;
    }

    public static Typing operator ++(Typing c)
    {
        throw new NotImplementedException();
    }

    public static Typing operator checked --(Typing c)
    {
        return null;
    }

    public static Typing operator --(Typing c)
    {
        return null;
    }

    public static Typing operator checked -(Typing t1, Typing t2)
    {
        return null;
    }

    public static Typing operator -(Typing t1, Typing t2)
    {
        return null;
    }

    public static Typing operator checked +(Typing t1, Typing t2)
    {
        return null;
    }

    public static Typing operator +(Typing t1, Typing t2)
    {
        return null;
    }

    public static Typing operator checked *(Typing t1, Typing t2)
    {
        return null;
    }

    public static Typing operator *(Typing t1, Typing t2)
    {
        return null;
    }

    public static Typing operator /(Typing t1, Typing t2)
    {
        return null;
    }

    public static Typing operator checked /(Typing t1, Typing t2)
    {
        return null;
    }

    //public static Typing operator checked <=(Typing t1, Typing t2)
    //{
    //    return null;
    //}

    public static explicit operator checked Typing2(Typing t1)
    {
        return null;
    }

    public static explicit operator Typing2(Typing t1)
    {
        return null;
    }
}

public class Typing2 : ITyping2
{
}