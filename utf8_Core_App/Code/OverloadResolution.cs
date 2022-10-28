namespace utf8_Core_App.Code;

public class OverloadResolution
{
    public void Test()
    {
        MethodWithOverload(""u8);
    }

    private string MethodWithOverload(ReadOnlySpan<byte> readOnlySpan)
    {
        return null;
    }
    private string MethodWithOverload(byte[] array)
    {
        return null;
    }
    private string MethodWithOverload(string array)
    {
        return null;
    }
}