namespace SAM_Core_App.Code;

public class Required1:IRequired
{
    public static void RequiredMethod()
    {
    }

    static string? IRequired.StringProperty { get; set; }

    void IRequired.RegularMethod()
    {
    }
}

public interface IRequired
{
    static abstract void RequiredMethod();

    static abstract string? StringProperty { get; set; }

    void RegularMethod();
}




public class Required2:IRequired
{
    public static void RequiredMethod()
    {
    }

    public static string? StringProperty { get; set; }
    public void RegularMethod()
    {
    }
}

public class Use1
{
    public void Test(Required1 required1)
    {
        Required1.RequiredMethod();
    }
}