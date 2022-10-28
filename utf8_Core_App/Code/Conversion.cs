namespace utf8_Core_App.Code;

public class Conversion
{
    #nullable disable
    private const string MyConstString = "const string";

    public void Test(ReadOnlySpan<byte> s)
    {
        s = "test"u8;
        foreach (var b in "test string"u8)
        {
            Console.WriteLine(b.ToString());
        }

        var myVar = "null"u8;
        var empty = Test2("myVar"u8 + ""u8,
            null);
    }

    private string Test2(ReadOnlySpan<byte> readOnlySpan, string stringParameter)
    {
        var onlySpan = "&&&&&"u8;
        var myVar = "null"u8;
        //var span = onlySpan + myVar;
        return null;
    }
}