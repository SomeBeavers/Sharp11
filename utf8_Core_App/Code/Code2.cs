namespace utf8_Core_App.Code;

public class Code2
{
    public void Test()
    {
        //string s1 = "hello"u8;             // Error
        //var s2 = "hello"u8;                // Okay and type is ReadOnlySpan<byte>
        //ReadOnlySpan<byte> s3 = "hello"u8; // Okay.
        //byte[] s4 = "hello"u8;             // Error - Cannot implicitly convert type 'System.ReadOnlySpan<byte>' to 'byte[]'.
        //byte[] s5 = "hello"u8.ToArray();   // Okay.
        //Span<byte> s6 = "hello"u8;         // Error - Cannot implicitly convert type 'System.ReadOnlySpan<byte>' to 'System.Span<byte>'.

        string s = null;
        ReadOnlySpan<byte> aa = null;
    }

    //public string GetString(ReadOnlySpan<byte> p1, ReadOnlySpan<byte> p2)
    //{
    //    return p1 + p2;
    //}
}

public static class MyStaticClass
{
    public static string GetString(this ReadOnlySpan<byte> p1, ReadOnlySpan<byte> p2)
    {
        return (p1.ToString() + p2.ToString());
    }
}

public class MyClass
{
    public void Test()
    {
        var s = "test"u8.GetString(p2: ""u8);
    }
}