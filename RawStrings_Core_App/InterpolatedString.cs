namespace RawStrings_Core_App;

public class InterpolatedString
{
    public int field = 1;

    public string Value => $$$"""
        test string/*caret*/
        {{{{field:D}}}}
        {field}
        """;

    public void Test()
    {
        var json = """
                   {
                      "summary": "text",
                      "length" : {
                    };
                   """;
    }
}