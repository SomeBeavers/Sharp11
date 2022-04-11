namespace Newlines_Core;

public class Formatting
{
    private void Test()
    {
        var firstOrDefault = TestMethod(true,
            1,
            0);

        var s = $"test {TestMethod(true, 1, 0)}";
    }

    string TestMethod(bool b, int t, int t2)
    {
        throw new NotImplementedException();
    }
}