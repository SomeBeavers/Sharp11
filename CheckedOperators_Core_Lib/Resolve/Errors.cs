namespace CheckedOperators_Core_Lib.Resolve;

public class Errors
{
    public struct Int128
    {
        // This is fine, both a checked and regular operator are defined
        public static Int128 operator checked -(Int128 lhs)
        {
            return default;
        }

        public static Int128 operator -(Int128 lhs)
        {
            return default;
        }

        // This is fine, only a regular operator is defined
        public static Int128 operator --(Int128 lhs)
        {
            return default;
        }

        // This should error, a regular operator must also be defined
        public static Int128 operator checked ++(Int128 lhs)
        {
            return default;
        }

        public static Int128 operator ++(Int128 lhs)
        {
            return default;
        }
    }

}