namespace RawStrings_Core_App;

public class SpecialSymbols
{
    public string stringField = """

        """;

    public void Test()
    {
        var phrase = "The quick brown fox jumps over the lazy dog.";
        var words = phrase.Split(' ');

        foreach (var word in words) Console.WriteLine($"<{word}>");

        var s = string.Empty;

        var text = "one\ttwo :,five six seven";
        var text2 = "one\ntwo :,five six seven";
        var text3 = "one\r\ntwo :,five six seven";
        var text4 = "This is a \"string\" in C#.";
        var str = "xyzdef\\rabc";
        var path = "\\\\mypc\\ shared\\project";
        var email = @"
    test
@
test.com";

        var str1 = "this is a \n" +
                   "multi line \n" +
                   "string";

// Verbatim string
        var str2 = @"this is a 
        multi line 
        string";

        Test2();
    }

    private static void Test2()
    {
        var text5 = """This is a "string" in C#."""; // valid
        //string text6 = @"This is a "string." in C#."; // error
        //string text7 = @"This is a \"string\" in C#."; // error
        var text8 = @"This is a ""string"" in C#."; // valid
        var text9 = """test with ""quotes" """;
        var text10 = """ \\\\\\""";
        var text11 = """{'{text10}'}""";
        var text12 = """ with escaping \""\\n """;

        Console.WriteLine("""
    {0:1}
    this 
    is
        string
        {1}
    """,
            text12,
            text10);
    }
}