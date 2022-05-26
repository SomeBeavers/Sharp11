namespace AutoDefaultStructs_Core_Lib;

public struct WarningsStruct
{
    // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
    private int t/*caret*/;

    public WarningsStruct()
    {
        Console.WriteLine(t);
    }

    public WarningsStruct(string s)
    {
    }
}