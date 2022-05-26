namespace AutoDefaultStructs_Nuget;

public struct StructFromNuget
{
    public StructFromNuget()
    {
    }

    public A PublicProperty { get; set; }
    public A? PublicField;
}

public class A
{
}