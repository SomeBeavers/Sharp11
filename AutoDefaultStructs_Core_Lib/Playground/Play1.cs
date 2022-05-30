namespace AutoDefaultStructs_Core_Lib.Playground;

public struct Play1_renamed
{
    public StructCor Field1;
    public InnerClass? InnerClass;
    private string? nameField;

    public Play1_renamed(string? name)
    {
        nameField = name;
        Field1.Age = 1;
        if (InnerClass != null) InnerClass.Name = "Jane Doe";
    }
}

public class InnerClass
{
    public string Name { get; set; }
}

public class UsePlay1
{
    private void Test()
    {
    }
}