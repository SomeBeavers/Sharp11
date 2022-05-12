namespace CheckedOperators_Core_Lib;

public class Resolve4
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

            // Resolves to `op_CheckedMultiply`
            Int128 r5 = checked(lhs * rhs);

            // Resolves to `op_CheckedMultiply`
            Int128 r51 = unchecked(lhs * rhs);
        }

        public static void Divide(Int128 lhs, byte rhs)
        {
            // Resolves to `op_CheckedDivision`
            Int128 r4 = checked(lhs / rhs);
        }
    }

    public struct Int128
    {
        public static Int128 operator checked +(Int128 lhs, Int128 rhs)
        {
            return default;
        }
        public static Int128 operator +(Int128 lhs, Int128 rhs)
        {
            return default;
        }

        public static Int128 operator -(Int128 lhs, Int128 rhs)
        {
            return default;
        }

        public static Int128 operator checked *(Int128 lhs, Int128 rhs)
        {
            return default;
        }

        public static Int128 operator checked /(Int128 lhs, int rhs)
        {
            return default;
        }

        public static Int128 operator /(Int128 lhs, byte rhs)
        {
            return default;
        }
    }
}