namespace CheckedOperators_Core_Lib.Resolve;
#nullable disable
public class Generic<T> where T : class
{
    public static Generic<T> operator checked /(Generic<T> g1, Generic<T> g2)
    {
        return null;
    }

    public static Generic<T> operator /(Generic<T> g1, Generic<T> g2)
    {
        return null;
    }
}

public class UseGeneric
{
    private void Test<U, V>(U g1, V g2) where U : Generic<UseGeneric> where V: Generic<UseGeneric>
    {
        var g3 = checked(g1 / g2);
    }
}