namespace RawStrings_Core_App;

public class Code1
{
    public void Test(string parameter)
    {
        var format = string.Format("""
    {0}
    """,
            parameter);
        var singleLine = """ "here:" """ + "test" + "another test";

        var multiline = """
            this is string: 
            "test"
            .
            """;
        var blank =
            """
                
            """;

        var multiline2 = 
                                        """
           
            test string "\n"




            
            """;

        var v1 = """
         ""The content of this string starts and ends with two quotes""
         """;

        var v2 = """
         ""The content of this string starts and ends with two quotes""
         """;
    }
}