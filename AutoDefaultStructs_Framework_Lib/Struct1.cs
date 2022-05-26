namespace AutoDefaultStructs_Framework_Lib
{
    public struct Struct1
    {
        public int x;
        private int y;

        public Struct1(bool b):this()
        {
            y = 1;
        }
    }

    public class UseStruct1
    {
        private void Test()
        {
            var i = new Struct1(true).x;
        }
    }

    class S
    {
        public int X
        {
            get;
            set;
        }

        public S() // error: backing field of 'S.X' is implicitly initialized to 'default'.
        {
            X = 1;
        }
    }
}