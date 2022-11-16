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

var s4 = """
    {{"\"}}
    test
    {order_number}
    """;

Console.WriteLine(s4);

//Console.WriteLine(format);