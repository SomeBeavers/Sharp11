namespace CheckedOperators_Core_Lib.Resolve;

public abstract class AbstractClass
{
    public static AbstractClass? operator checked ++(AbstractClass? ac)
    {
        return null;
    }

    public static AbstractClass operator ++(AbstractClass ac)
    {
        return null!;
    }

    public static explicit operator checked A(AbstractClass ac)
    {
        return null;
    }

    public static explicit operator A(AbstractClass ac)
    {
        return null;
    }
}

public class A
{
}

class AbstractClassImpl : AbstractClass
{
}

public class UseAbstract
{
    private void Test(AbstractClassImpl aci)
    {
        var abstractClass = (AbstractClass)aci;
        var t = checked(abstractClass++);
        var t2 = unchecked(abstractClass++);
        var t3 = abstractClass++;

        Console.WriteLine(abstractClass);
    }
}