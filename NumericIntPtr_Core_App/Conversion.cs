namespace NumericIntPtr_Core_App;

public class Conversion
{
    public void Test(IntPtr intPtr, UIntPtr uintPtr)
    {
        object t = intPtr;
        object t2 = uintPtr;

        MyEnum aMyEnum = (MyEnum)intPtr;
        MyEnum aMyEnum2 = (MyEnum)uintPtr;

        sbyte sb = (sbyte)intPtr;
    }
}

enum MyEnum
{
    a,b,c,d,e,f,
}