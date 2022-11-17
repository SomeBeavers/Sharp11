namespace RawStrings_Core_Lib.Refactorings;

public class IntroduceField
{
    public void Test(bool anotherS)
    {
        var s = $$$$"""
                "some comment"
                {{{aaaaa}}}
            {{{{
                anotherS.ToString()
            +
            $"{anotherS}"
            }}}}
            """;
        var s2 = string.Format(@"
    
            {0}
            ",
            anotherS.ToString()
            +
            $"{anotherS}");
    }
}