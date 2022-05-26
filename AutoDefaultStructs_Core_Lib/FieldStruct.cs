namespace AutoDefaultStructs_Core_Lib;

public struct FieldStruct
{
    public const int MyConstField = 1;
    public static int MyIntField = MyConstField;
    public int MyAnotherIntField;

    public FieldStruct() => MyIntField = 2;

    public static FieldStruct CreateInstance()
    {
        return new FieldStruct();
    }
}

public class UseFieldStruct
{
    private void Test()
    {

    }
}