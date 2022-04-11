namespace Newlines_Core;

public class Refactorings
{
    private void Test()
    {
        var logMessage = $"{new List<InnerClass>()
            .Where(item => item.BooleanProperty1)
            .Select(x => x.BooleanProperty1)
            .FirstOrDefault()}";
    }
}