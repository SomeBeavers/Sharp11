// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public interface IInterface1
{
    static abstract void AbstractMethod();
    static virtual string? VirtualMethod()
    {
        return null;
    }

    void Method();
}

class Class1 : IInterface1
{
    public static void AbstractMethod()
    {
    }

    public static string? VirtualMethod()
    {
        return null;
    }

    public void Method()
    {
    }
}