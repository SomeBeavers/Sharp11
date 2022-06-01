// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

[MyAttribute(nameof(parameter))]
void Method1(string parameter)
{
}

public class MyAttribute : Attribute
{
    public MyAttribute(string parameter1)
    {
    }
}
