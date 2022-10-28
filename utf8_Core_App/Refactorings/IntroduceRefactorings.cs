namespace utf8_Core_App.Refactorings;

public class IntroduceRefactorings
{
    public void Test()
    {
        var localVar = GetUtf8();


        var test2 = Test2("some cool string"u8);
    }

    private static ReadOnlySpan<byte> GetUtf8()
    {
        ReadOnlySpan<byte> readOnlySpan2;
        var readOnlySpan = "some"u8 +
                           " "u8 + "cool"u8 + " "u8 + "string"u8;
        return readOnlySpan;
    }

    private string Test2(ReadOnlySpan<byte> readOnlySpan)
    {
        byte[] array = "test string is written here"u8.ToArray();
        return readOnlySpan.ToString();
    }
}