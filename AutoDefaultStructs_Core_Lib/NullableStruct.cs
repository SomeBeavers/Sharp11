namespace AutoDefaultStructs_Core_Lib;

public struct NullableStruct
{
    public NullableType? MyField;
    public NullableType MyField2;

    public NullableStruct(NullableType myField2)
    {
        MyField2 = myField2;
    }
}

public class NullableType
{
}