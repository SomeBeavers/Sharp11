namespace RawStrings_Core_App;

public class InterpolatedString
{
    public int field = 1;

    public string Value => $$$"""
        test string/*caret*/
        {{{{field:D}}}}
        {field}
        """;

    public void Test(DateTime parameter)
    {
        var json = """
                   {
                      "summary": "text",
                      "length" : {  
                   };
                   """;
        var s1 = $$"""
                      {test}
                      {{parameter}}
                      {{{parameter}}}
                      """;
        var v1 = $$"""X{{{1 + 1}}}Z""";
// == X{2}Z

        var s2 = $$"""
            {{
                field
                + 
                1
            }}

            """;

        var singleLine = $$$"""
    {{{s2}}}
    
    
    """;
    }
}