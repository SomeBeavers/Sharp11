namespace RawStrings_Core_App;

public class Errors
{
    public void Test(string parameter)
    {
        //string v = """""";
        //string error1 = """"
        //    "comment"
        //    is here
        //    """";
        //var error2 = ""test"""aaa""" new test"";
        //var error3 = "" "" "";

        var error4 = $$""" 
        test string
        {{$""" 
            {parameter} 
            """}}
        {{$@"
some verbatim string
{parameter}

-_-

"}}
        """;

        //var error5 = $$"""
        //    {{{parameter}}}}
        //    """;
        //var v1 = $$"""X{{{{1+1}}}}Z""";

        //var error6 = $$"test";

        //var error7 = $$"""{{error4}""";

        //var error8 = """    
        
        //test
        //""""another string""""

        //""";

    //    var v1 = """
    //     Start
    //e
    //     End
    //     """;

    //var v1 = """
    //     """;
    //var xml = """
    //      <element attr="content">
    //        <body>
    //        </body>
    //      </element>""";
    //var xml2 = """
    //      <element attr="content">
    //        <body>
    //        </body>
    //      </element>
    //          """;
    }
}