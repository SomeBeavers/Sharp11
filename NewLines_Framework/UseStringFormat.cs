using System;

namespace NewLines_Framework
{
    public class UseStringFormat
    {
        private void UseStringFormat1(string parameter1, string parameter2)
        {
            var s = string.Format("{0}{1}",
                MethodWithMultipleLines(1,
                    2).Length,
                parameter1.Length == 1
                &&
                parameter2.Length == 1);

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
}