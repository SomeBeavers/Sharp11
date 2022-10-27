namespace utf8_Core_App.Code;

public class Errors
{
    public void Test(ReadOnlySpan<byte> parameter)
    {
        const string text = "hello \uD801\uD802";
        foreach (var b in "hello \uD801\uD802"u8)
        {
            Console.WriteLine(b);
        }
    }
}