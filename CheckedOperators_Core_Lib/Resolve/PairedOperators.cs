namespace CheckedOperators_Core_Lib.Resolve;

public interface IPairedOperators
{
}

public class PairedOperators : IPairedOperators
{
    public static PairedOperators operator checked +(PairedOperators p, int t)
    {
        return null;
    }

    public static PairedOperators operator +(PairedOperators p1, int t1)
    {
        return null;
    }
}