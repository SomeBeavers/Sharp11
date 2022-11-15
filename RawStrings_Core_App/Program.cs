var s1 = """ """;


Console.WriteLine("Hello, World!");


var s = """test string "with test";\n""";
var s2 = """"comment is here:"""test comment""" is here;"""";
var s3 = """comment""";

var format = string.Format("""
    test
    {0}
    """,
    1);

var aC2 = $"""{"ARG"}[a-c]* """;

Console.WriteLine(aC2);

//Console.WriteLine(format);