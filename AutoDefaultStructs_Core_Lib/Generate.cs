namespace AutoDefaultStructs_Core_Lib;

public struct GenerateStruct
{
    private int age;
    private string name;

    public GenerateStruct(int age)
    {
        this.age = age;
    }

    public GenerateStruct(int i, string name)
    {
        this.name = name;
    }

    public string Name
    {
        readonly get => name;
        set => name = value;
    }
}

public class UseGenerateStruct
{
    private void Test()
    {
        var generateStruct = new GenerateStruct(1, "John Doe")
        {
            Name = "Jane Doe"
        };
    }
}