namespace utf8_Core_App.Code;

public ref struct Use
{
    private readonly ReadOnlySpan<byte> dog = "dog"u8;

    public Use()
    {
    }

    public void Method1()
    {
        var span = "my cool string"U8;
        byte[] array = span.ToArray();

        ReadOnlySpan<byte> s = dog;
    }
}

public class UseClass
{
    const string first = "\uD83D";  // high surrogate
    const string second = "\uDE00"; // low surrogate

    public void Test()
    {
        //ReadOnlySpan<byte> span = (first + second);
        var span = "2"u8 + "1"u8;
    }
}