using CheckedOperators_Core_Lib;

namespace CheckedOperators_Core_Console_WithCheckedInCsproj;

public class UseReferencedProject
{
    private void Test(Typing t1, Typing t2)
    {
        var typing = t2 + t1;
    }
}