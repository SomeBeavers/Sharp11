// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class InnerClassInTopLevel
{
    public required string Name { get; set; }
    public required string Name2 { get; set; }
}

class MyClass
{
    public string S { get; set; }
}

class UseInnerClassInTopLevel
{
    public void Test()
    {
        var myClass = new MyClass() { S = "" };
        var innerClassInTopLevel = new InnerClassInTopLevel
        {
            Name = null!,
            Name2 = null!
        };
    }
}