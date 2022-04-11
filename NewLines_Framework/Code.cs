namespace NewLines_Framework
{
    public class Code
    {
        private void Test()
        {
            string renamedNullableString = null;
            var length = renamedNullableString
                .Length;
            var a2 =
                $"test:{length}";
        }
    }
}