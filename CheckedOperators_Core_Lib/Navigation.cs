namespace CheckedOperators_Core_Lib;
#nullable disable
public class Navigation
{
    public static Navigation operator checked /*caret*/+(Navigation n1, Navigation n2)
    {
        return null;
    }

    public static Navigation operator +(Navigation n1, Navigation n2)
    {
        return null;
    }
}

public class UseNavigation
{
    private void Test(Navigation n1, Navigation n2)
    {
        var test = checked(n1 + n2);
        var test2 = unchecked(n1 + n2);
        //var test3 = unchecked(n1 + n2);
    }
}