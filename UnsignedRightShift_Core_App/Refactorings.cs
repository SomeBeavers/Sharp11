namespace UnsignedRightShift_Core_App;

public class Refactorings
{
    private static IntPtr AnotherStaticField = 12;
    public static nint StaticField = AnotherStaticField>>> ConstInt;
    private const int ConstInt = 1;


    public void Test(int i1_renamed, int? i2)
    {
        int? i1 = i1_renamed >>> i2;
    }
}