using System.Diagnostics.CodeAnalysis;

namespace NumericIntPtr_Core_App;

public class Code2
{
    public void Test()
    {
        ulong t = 1;
        short? tt = 0;
        int i = 0;

        nint nint1 = 1;
        nuint nuint1 = 1;

        System.IntPtr intPtr1 = 1;
        System.UIntPtr uintPtr1 = 1;


        // nullable 
        nint? t1 = 1;
        System.IntPtr? t2 = 1;        
        System.UIntPtr? t23 = 1;

        long[] collection = null;

        var l = collection[intPtr1];

        var list = new List<nint> { intPtr1 };
    }
}