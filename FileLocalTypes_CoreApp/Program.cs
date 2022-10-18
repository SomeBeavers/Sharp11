// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
