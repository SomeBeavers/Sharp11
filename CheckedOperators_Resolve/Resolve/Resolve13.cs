namespace CheckedOperators_Core_Lib;

public class Resolve13
{
    class C
    {
        static void Add(C2 x, byte y)
        {
            object o;
        
            // C2.op_CheckedAddition
            o = checked(x + y);
        
            // C1.op_Addition
            o = unchecked(x + y);
        }

        static void Add2(C2 x, int y)
        {
            object o;
        
            // C1.op_Addition
            o = checked(x + y);
        
            // C1.op_Addition
            o = unchecked(x + y);
        }
    }

    class C1
    {
        public static C1 operator + (C1 x, int y) => new C1();
    }

    class C2 : C1
    {
        public static C2 operator checked + (C2 x, byte y) => new C2();
    }
}