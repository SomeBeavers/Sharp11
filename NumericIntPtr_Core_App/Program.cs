// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

public partial class Class1
{
    readonly IntPtr Value;

    public Class1(nint value)
    {
        Value = value;
    }

    public long Test()
    {
        return Value;
    }
}