namespace CheckedOperators_Core_Lib;

public class Resolve10
{
    class C
    {
        static void Add(C2 x, C3 y)
        {
            object o;
        
            // C1.op_CheckedAddition
            o = checked(x + y);
        
            // C2.op_Addition
            o = x + y;
        }
    }

    class C1
    {
        public static C1 operator checked + (C1 x, C3 y) => new C3();
    }

    class C2 : C1
    {
        public static C2 operator + (C2 x, C1 y) => new C2();
    }

    class C3 : C1
    {
    }
}