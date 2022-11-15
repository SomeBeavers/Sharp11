namespace RawStrings_Core_App;

public class LanguageInjection
{
    public void Test(int order_number)
    {
        var aC = """[a-c]*""";
        var aC2 = """
    [a-c]*
    +
    [b]*
    """;

        string test = "";
        var s = $$"""
        {{test}}
        """;

        var s1 = $"{test}";

        var s2 = """
            a, .btn-link {
                     color: #0071c1;
                 }
            """;

        var empty = """
                    a, .btn-link {
                        color: #0071c1;
                    }
                    """;

        var v1 = $$"""
         {
            "orders": 
            [
                { "number": {{order_number}} }
            ]
         }
         """;
    }
}