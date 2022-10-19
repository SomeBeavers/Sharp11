// See https://aka.ms/new-console-template for more information
file class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var inTopLevel = new InnerClassInTopLevel
        {
            Name = "null"
        };

        Console.WriteLine();
    }
}

file sealed class InnerClassInTopLevel
{
    public required string Name { get; init; }
}

public class UseInnerClassInTopLevel
{
    public void Test()
    {
        var classInTopLevel = new InnerClassInTopLevel
        {
            Name = "Jane Doe"
        };

        Console.WriteLine(classInTopLevel.Name);
    }
}

file class A{}
