namespace RawStrings_Core_Lib.Refactorings;

[My(""" 
cool string parameter "here"
@"\|!#$%&/()=?»«@£§€{}.-;'<>_,"
""")]
public class SmartCopyPaste
{
    public void Test()
    {
    }
}

public class MyAttribute : Attribute
{
    public MyAttribute(string myparameter)
    {
        myparameter = "— — 3333 ~~~~ 9999 :::: 8888 ;;;; 6776 ```` 2332 ‘’’’ 3323 “””” 4343 @@@@";
        myparameter = """
^[a-zA-Z0-9-]+$^[a-zA-Z0-9-]
+$
""";
        myparameter = "@\"\\|!#$%&/()=?»«@£§€{}.-;'<>_,\"";

        string a = string.Empty;

        myparameter = $$"""
            {{a}} /*caret*/"this is a text {}"
            """;

        myparameter = $$"""
            {a}
            {
                "glossary": {
                    "title": "example glossary",
            		"GlossDiv": {
                        "title": "S",
            			"GlossList": {
                            "GlossEntry": {
                                "ID": "SGML",
            					"SortAs": "SGML",
            					"GlossTerm": "Standard Generalized Markup Language",
            					"Acronym": "SGML",
            					"Abbrev": "ISO 8879:1986",
            					"GlossDef": {
                                    "para": "A meta-markup language, used to create markup languages such as DocBook.",
            						"GlossSeeAlso": ["GML", "XML"]
                                },
            					"GlossSee": "markup"
                            }
                        }
                    }
                }
            }
            """;

        myparameter = "";
    }
}