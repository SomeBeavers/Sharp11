namespace RawStrings_Rider;

public class Rider1
{
    public const string constString = "";
    public string Property1 =>$$"""
    {{constString}}
    """;
    public string Property2 =>$@"
    {{{constString}}}
    ";

    public void Test()
    {
        var s = """
               <!DOCTYPE glossary PUBLIC "-//OASIS//DTD DocBook V3.1//EN">
        <glossary><title>example glossary</title>
         <GlossDiv><title>S</title>
          <GlossList>
           <GlossEntry ID="SGML" SortAs="SGML">
            <GlossTerm>Standard Generalized Markup Language</GlossTerm>
            <Acronym>SGML</Acronym>
            <Abbrev>ISO 8879:1986</Abbrev>
            <GlossDef>
             <para>A meta-markup language, used to create markup languages such as DocBook.</para>
             <GlossSeeAlso OtherTerm="GML"/>
             <GlossSeeAlso OtherTerm="XML"/>
             <GlossSeeAlso OtherTerm='test'/>
            </GlossDef> 
        """+"""
            <GlossSee OtherTerm="markup"/>
           </GlossEntry>
          </GlossList>
         </GlossDiv>
        </glossary>
        """;
        
        var s2 =$$$"""
{{{constString}}}
 
""";
    }
    
    public void Test2()
    {
     var s2 = $"{constString}";
    }
}