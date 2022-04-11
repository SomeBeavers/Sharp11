namespace Newlines_Core;

public class Code
{
    private const string Name = "code";
    private const string Description = "description";
    private const string Type = "type";
    private const string Value = "value";

    private string field = $"{Name.Length.ToString().Clone()}";

    private void Test()
    {
        var renamed =
                Name
                    .Length.ToString()
            ;

        var testcontains = "testContains";

        var s = $"test here: {renamed.Contains(testcontains)}";

        string renamedNullableString = null;
        var length = renamedNullableString!
            .Length;
        int newLength = 10;

        var a2 =
            $"test:{
                length
                + newLength} {
                newLength
                }";
    }
}