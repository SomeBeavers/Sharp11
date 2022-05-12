namespace CheckedOperators_Core_Framework;

public class Overload2
{
    public class MyClass
    {
        public static void Add(Int128 lhs, Int128 rhs)
        {
            // Resolves to `op_CheckedAddition`
            Int128 r1 = checked(lhs + rhs);

            // Resolves to `op_Addition`
            Int128 r2 = unchecked(lhs + rhs);

            // Resolve to `op_Subtraction`
            Int128 r3 = checked(lhs - rhs);

            // Resolve to `op_Subtraction`
            Int128 r4 = unchecked(lhs - rhs);
        }

        public static void Multiply(Int128 lhs, byte rhs)
        {
            // Resolves to `op_Multiply` even though `op_CheckedMultiply` is also applicable
            Int128 r4 = checked(lhs * rhs);
        }
    }

    public struct Int128
    {
        public static Int128 operator checked +(Int128 lhs, Int128 rhs);
        public static Int128 operator +(Int128 lhs, Int128 rhs);

        public static Int128 operator -(Int128 lhs, Int128 rhs);

        public static Int128 operator checked *(Int128 lhs, int rhs);
        public static Int128 operator *(Int128 lhs, byte rhs);
    }
}