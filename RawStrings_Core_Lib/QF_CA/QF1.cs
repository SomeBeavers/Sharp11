namespace RawStrings_Core_Lib.QF_CA;

public class QF1
{
    public string Name
    {
        get => $$"""{{null}}""";
        set { }
    }

    public string S => string.Format("{0} {{}} test \"\"in quotes\"\" {1}\n", 1, 2);
    public string S2 => string.Format("{0} test \"in quotes\" {1}\n", 1, 2);

    public void Test()
    {
        string s = "test \"in quotes\"";
        string format;
        format = $"""
                                   {1} test "in quotes" {2}
                                   
                                   """;
        var s2 = $$"""test string {} {{s}}""";

        var s3 = $$$"""
                 {
                             "orders": 
                             [
                                 { "number": {{{{{order_number}}}}} }
                             ]
                 }
                 """;
        var s4 = """
    {{"\"}}
    {order_number}
    """;

        var s5 = $$$""" "{{{0b1}}}" """;
        var s6 = $"\"{0b1}\"";
    }

    private const int order_number = 1;
}