namespace UnsignedRightShift_Core_App;

public class InterfaceImplementation : IInterface
{
    public ulong Test()
    {
        return 12>>> 1;
    }
}

public interface IInterface
{
    public ulong Test();
}

public readonly struct Fraction
{
    private readonly int num;
    private readonly int den;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.",
                nameof(denominator));
        num = numerator;
        den = denominator;
    }

    public static Fraction operator >>> (Fraction a, Fraction b)
    {
        return new Fraction(a.num * b.den + b.num * a.den,
            a.den * b.den);
    }
}

public static class OperatorOverloading
{
    public static void Main()
    {
        var a = new Fraction(5,
            4);
        var b = new Fraction(1,
            2);
        var fraction = a>>> b;
    }
}

public class C
{
    public void M(C x)
    {
        x >>>= 1;

        Console.WriteLine(x);
    }

    public static C operator >>> (C c, bool t)
    {
        return null;
    }
    public static C operator >>> (C c, int t)
    {
        return null;
    }
}
