namespace AutoDefaultStructs_Core_Lib;

public struct Struct1
{
    private int x;
    private int y;

    public Struct1()
    {
        Console.WriteLine(x);
    }
}

class MyClass
{
    private int x;

    public MyClass()
    {
        
        x = 1;
        Console.WriteLine(x);
    }
}