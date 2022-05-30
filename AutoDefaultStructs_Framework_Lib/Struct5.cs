using System;

namespace AutoDefaultStructs_Framework_Lib;
#nullable enable



public interface IStruct5
{
    InnerClass? InnerClass { get; }
}

public struct Struct5 : IStruct5
{
    public Struct5(string name)
    {
        if (InnerClass != null) InnerClass.Name = name;
    }

    public Struct5(InnerClass? ic)
    {
        this.InnerClass = ic;
    }

    public InnerClass? InnerClass
    {
        get => null;
        private set
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
        }
    }
}

public abstract class InnerClass
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

public class UseStruct5
{
    private void Test(string name)
    {
        var struct5 = new Struct5(name);
        Console.WriteLine(struct5.InnerClass);
    }
}