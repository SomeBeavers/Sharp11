namespace AutoDefaultStructs_Core_Lib;

public struct StructCor
{
    public MyProp? field;
    public int Age;

    public StructCor(string name)
    {
        Console.WriteLine(name);
        if (field != null)
        {
            Console.WriteLine();
        }
        field = null!;
    }

    public StructCor(MyProp? field):this()
    {
        this.field = field;

        if (Age == default)
        {
            //Age = 42;
        }
    }

    public StructCor()
    {
    }
}

public class UseStructCor
{
    public int Age;
    private void Test()
    {        
        if (Age == default)
        {
            Age = 42;
        }
        var structCor = new StructCor();
        Console.WriteLine(structCor.field);
    }
}