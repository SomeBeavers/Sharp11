namespace AutoDefaultStructs_Core_Lib;

public record struct RecordStruct
{
    private int t;
    private InnerClass? innerClass;

    class InnerClass
    {
    }

    public RecordStruct()
    {
        innerClass = new();
    }
}