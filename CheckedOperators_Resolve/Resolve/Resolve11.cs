namespace CheckedOperators_Core_Lib;

public class Resolve11
{
    class C
    {
        static void Add(C2 x, C3 y)
        {
            object o;
        
            // C2.op_CheckedAddition
            o = checked(x + y);
        
            // C1.op_Addition
            o = x + y;
        }
    }

    class C1
    {
        public static C1 operator + (C1 x, C3 y) => new C3();
    }

    class C2 : C1
    {
        public static C2 operator checked + (C2 x, C1 y) => new C2();
    }

    class C3 : C1
    {
    }
}