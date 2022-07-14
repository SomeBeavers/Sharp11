using System;

namespace Nameof_Framework_Lib;

public class Class1
{

    public const string parameter = "";

    [My(nameof(parameter))]
    private void M(int parameter)
    {
        Console.WriteLine(parameter);
    }

    [MyAttribute(nameof(UParemeter))]
    private void M<TParameter, UParemeter>()
    {
    }

    private void M(int parameter, [MyAttribute(nameof(parameter))] int other)
    {
    }
}

public class MyAttribute : Attribute
{
    public MyAttribute(string t)
    {
    }
}