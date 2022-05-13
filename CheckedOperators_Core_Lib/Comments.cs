namespace CheckedOperators_Core_Lib;

public class Comments
{
    public static Comments? operator checked ++(Comments c)
    {
        return null;
    }

    public static Comments? operator ++(Comments c)
    {
        return null;
    }
}

public class UseComments
{
    /// <summary>
    /// See <see cref="Comments.op_CheckedIncrement"/> or <see cref="Comments.op_Increment"/>
    /// </summary>
    private void Test(Comments c)
    {
        var s = checked(c++);
    }
}