namespace CheckedOperators_Core_Lib;

public class Resolve12
{
    class C
    {
        static void Add(C2 x, byte y)
        {
            object o;
        
            // C2.op_Addition
            o = checked(x + y);
        
            // C2.op_Addition
            o = unchecked(x + y);
        }

        static void Add2(C2 x, int y)
        {
            object o;
        
            // C2.op_Addition
            o = checked(x + y);
        
            // C2.op_Addition
            o = unchecked(x + y);
        }
    }

    class C1
    {
        public static C1 operator checked + (C1 x, byte y) => new C1();
    }

    class C2 : C1
    {
        public static C2 operator + (C2 x, int y) => new C2();
    }
}