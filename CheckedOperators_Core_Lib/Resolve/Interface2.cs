namespace CheckedOperators_Core_Lib.Resolve;

public interface Interface2
{
    static abstract Interface2 operator checked ++(Interface2 i1);
    static abstract Interface2 operator ++(Interface2 i1);
}

class MyInterface2 : Interface2
{
    static Interface2 Interface2.operator checked ++(Interface2 i1)
    {
        return null;
    }

    static Interface2 Interface2.operator ++(Interface2 i1)
    {
        return null;
    }
}

class MyClass
{
    public static MyClass operator checked ++(MyClass mc)
    {
        return null;
    }

    public static MyClass operator ++(MyClass mc)
    {
        return null;
    }
}

