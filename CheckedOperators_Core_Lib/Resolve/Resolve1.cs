namespace CheckedOperators_Core_Lib.Resolve;
#nullable disable
public class Resolve1
{
    public static Resolve1 operator +(Resolve1 r1, Resolve1 r2)
    {
        return new Resolve1();
    }

    public static Resolve1 operator checked +(Resolve1 r1, Resolve1 r2)
    {
        return null;
    }
}

public class UseResolve1
{
    private void Test(Resolve1 r1, Resolve1 r2)
    {
        checked
        {
            if (r1 + r2 != null) Console.WriteLine(r1 + r2);
            var test = r1 + r2;
        }

        var resolve1 = r1 + r2;

        unchecked
        {
            if (r1 + r2 != null) Console.WriteLine(r1 + r2);
            var test = r1 + r2;
        }
    }
}