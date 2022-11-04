using System;

namespace NumericIntPtr_Framework_Lib;

public class Class1
{
    private readonly IntPtr constField;

    public Class1()
    {
        constField = (IntPtr)2;
        var t = new nuint();

       // long t1 = constField;
    }

    public void Test(IntPtr intPtr, UIntPtr uintPtr)
    {
        object t = intPtr;
        object t2 = uintPtr;

        sbyte sb = (sbyte)intPtr;
    }
}

public unsafe class UnsafeContext
{
    public void Test(IntPtr parameter1, UIntPtr parameter2, long* a)
    {
       // var l = a + parameter1;
    }
}