namespace Nameof_Core_App;

public class Refactorings
{
    public const string inlineMe1 = "";

    [InlineAttribute(nameof(inlineMe_renamed))]
    public void Test(string inlineMe_renamed/*caret*/)
    {
        Console.WriteLine(inlineMe_renamed);
    }

    public void UseTest()
    {
        Test("");
    }
}

public class InlineAttribute : Attribute
{
    public InlineAttribute(string parameter)
    {
    }
}