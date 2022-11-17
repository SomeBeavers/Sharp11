namespace RawStrings_Rider;

public class Rider2
{
    public void Test(DateTime newVar)
    {
        var s = """
            "this is a test string"
        
        """+
                $$"""
                 {{
                     newVar
                         .Date
                     
                 }}
                {
                }
                    test
                """;
        var s2="""
            CREATE OR REPLACE VIEW [Brazil Customers] AS
            SELECT CustomerName, ContactName, City
            FROM Customers
            WHERE Country = 'Brazil';
        """;
        
        var a = "aa";
        var b = "bb";
        var str = """
                  a is '{
                              a}' and b is {b}
                  """;

    //comment
    
    }
}