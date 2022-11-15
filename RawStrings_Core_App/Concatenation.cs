namespace RawStrings_Core_App;

public class Concatenation
{

    public  string constField = $$$"""
        this is a ~~single~~ multiline
        raw string
        {{{{{
            AnotherConstField:M/d/yy}}}}}
        """;

    private  static DateTime AnotherConstField = default;

    public bool Test(string? t)
    {
        var useAnotherMethod = UseAnotherMethod(t);
        var concat1 = $$""""
            this is a string
            {{useAnotherMethod}}
            {"""test comment"""}
            """" + useAnotherMethod +
                      """

                      """;

        return false;

    }

    private string UseAnotherMethod(string? s)
    {
        return null;
    }
}