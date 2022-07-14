// See https://aka.ms/new-console-template for more information
using Nameof_Core_Nuget;

Console.WriteLine("Hello, World!");

//[MyAttribute(nameof(parameter))]
//void Method1(string parameter)
//{
//}

[My(nameof(myParameter))]
void Method1([My(nameof(ClassFromNuget.ConstStringFromNuget))]A myParameter, string ConstStringFromNuget1)
{
}

public class MyAttribute : Attribute
{
    public MyAttribute(string parameter1)
    {
    }

    public MyAttribute(string parameter1, string parameter2){}
}

public class ClassFromNuget1
{
    public const string ConstStringFromNuget = "";
}

public class A
{
}
