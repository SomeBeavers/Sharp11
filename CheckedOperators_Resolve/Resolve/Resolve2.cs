﻿namespace CheckedOperators_Core_Lib;

public class Resolve2
{
    class C
    {
        static void Add(C2 x, C3 y)
        {
            object o;
        
            // error CS0034: Operator '+' is ambiguous on operands of type 'C2' and 'C3'
            o = checked(x + y);
        
            // C2.op_Addition
            o = unchecked(x + y);
        }
    }

    class C1
    {
        // Cannot be declared in C#, but could be declared by some other language
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