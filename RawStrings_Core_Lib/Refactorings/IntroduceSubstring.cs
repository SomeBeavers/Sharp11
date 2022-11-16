namespace RawStrings_Core_Lib.Refactorings;

public class IntroduceSubstring
{
    public static string StringField = """ 
    "lets" {{introduce}}
    substring "" here ""
    ;
    """;
    public string StringField2 = $$""" 
    "lets" {{StringField}}
    substring "" here ""
    ;
    """;

    public string StringField3 = $@" 
    ""lets"" {StringField}
    substring "" here ""
    ;
    ";

    public void Test()
    {
        var s1 = $@" 
    ""lets"" {StringField}
    substring "" here ""
    ;
    ";
        var s2 = ";";
        var s3 = """ """;

        DateTime.Now.ToString("""
    yyyy {MMMM} dd{{
    }}
    """
);

        var s4 = """
                 yyyy {MMMM} dd{{
                 }}
                 """;

        var s5 = @"yyyy {MMMM} dd{{
}}";



    }
}