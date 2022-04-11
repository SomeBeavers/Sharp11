namespace Newlines_Core;

public class UseInterpolation
{
    private void UseStringFormat(string parameter1, string parameter2)
    {
        var s = $"{MethodWithMultipleLines(1, 2).Length



        }{
            parameter1.Length == 1
            &&
            parameter2.Length == 1}";

        var newS = string.Format("{0}{1}",
            MethodWithMultipleLines(1,
                2).Length,
            parameter1.Length == 1
            &&
            parameter2.Length == 1);
    }

    private string MethodWithMultipleLines(int i, int i1)
    {
        throw new NotImplementedException();
    }
}