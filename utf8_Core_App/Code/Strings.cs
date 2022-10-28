namespace utf8_Core_App.Code;

public class Strings
{
    public const string ConstString = "";

    public void Test(ReadOnlySpan<byte> parameter)
    {
        var verbatimString = @"AUTH \\

\\
""
"U8;

        var multiline = "my"u8 +
                        "multi"u8 +
                        "line"u8;

        //var format = String.Format("{0}"u8, 1.ToString());
    }

    public void Concatenation(ReadOnlySpan<byte> parameter)
    {
       // var empty = parameter + ""u8;
    }
    public void Concatenation(byte[] parameter)
    {
        //var empty = parameter + ""u8;
    }

    public static void MyStaticMethod()
    {
        //ReadOnlySpan<byte> constString = ConstString;

        //const ReadOnlySpan<byte> readOnlySpan = null;
    }
    //public object Concatenation() => "hello \uD801\uD802" + ""u8;


    private void UseStringFormat(string parameter1, string parameter2)
    {
        var newS = string.Format("{0}{1}",
            MethodWithMultipleLines(1,
                2).Length,
            @"?"u8.ToString());
    }

    private string MethodWithMultipleLines(int i, int i1)
    {
        throw new NotImplementedException();
    }
}