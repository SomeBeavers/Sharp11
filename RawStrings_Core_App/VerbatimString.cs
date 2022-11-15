namespace RawStrings_Core_App;

public class VerbatimString
{
    public string VerbatimProp => @"
    it is a verbatim string
""comment""""""
here
";
    public string VerbatimProp2 => @"
    it is a verbatim string
""comment""""""
here
";
    public void Test()
    {
        
    }
}