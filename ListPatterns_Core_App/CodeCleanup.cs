namespace ListPatterns_Core_App;

public class CodeCleanup
{
    public void Test(B[] collection, int[] sourceObject)
    {
        switch (collection)
        {
            case
            [
            ]:
                break;
        }

        var matches = sourceObject is [
                                          1, > 0, not 42,
                                      ];
    }

    void MatchMessage(string message)
    {
        var result = message is ['a' or 'A', .. var s, 'a' or 'A']
            ? $"Message {message} matches; inner part is {s}."
            : $"Message {message} doesn't match.";
        Console.WriteLine(result);
    }

    void Validate(int[] numbers)
    {
        var result = numbers is [< 0, .. { Length: 2 or 4 }, > 0] ? "valid" : "not valid";
        Console.WriteLine(result);
    }
}

public class B
{
    public string NameB { get; set; }
    public C C { get; set; }
}

public class C
{
    public string NameC { get; set; }
}