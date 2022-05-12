namespace CheckedOperators_Core_Framework
{
    public class Overload1
    {
        public static Overload1 operator checked ++(Overload1 o1)
        {
            return null;
        }

        public static Overload1 operator ++(Overload1 o1)
        {
            return null;
        }
    }

    public class UseOverload1
    {
        private  void Test(Overload1 o1)
        {
            checked
            {
                var s = o1++/*caret*/;
                
            }

            var s2 = o1++;

            unchecked
            {
                o1++;
            }
        }
    }
}