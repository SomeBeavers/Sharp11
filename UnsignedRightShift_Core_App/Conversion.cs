namespace UnsignedRightShift_Core_App;

public class Conversion
{

    static ulong staticField = UInt64.MaxValue;

    static readonly ulong longField = staticField>>> _i;
    private static int _i = 1;

    public void Test()
    {
        Test1(staticField>>>_i);
    }

    public void Test1(ulong ulongParameter)
    {
    }
    public void Test1(nint ulongParameter)
    {
    }
}