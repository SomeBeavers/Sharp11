namespace CheckedOperators_Core_Lib.Resolve;

public interface Interface1
{
    static Interface1 operator checked *(Interface1 i1, Interface1 i2)
    {
        return null;
    }

    abstract static Interface1 operator *(Interface1 i1, Interface1 i2)
    {
        return null;
    }
}

public class UseInterface
{
    private void Test(Interface1 i1, Interface1 i2)
    {
        var s = checked(i1 * i2);
        unchecked
        {
            var s2= i1 * i2;
        }
    }
}