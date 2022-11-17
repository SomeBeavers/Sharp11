namespace RawStrings_Core_App;
using System.CodeDom;
public class Class1
{
    public void Test()
    {
        //"""""";
        string s ="""comment""";
        string s2 = $$$"""
            my string 
            "here"
            {{{s}}}
            """;
        string s23 = $"{s}";
    }
}