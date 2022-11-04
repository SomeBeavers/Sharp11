namespace NumericIntPtr_Core_App;

public unsafe class UnsafeContext
{
    public void Test(IntPtr parameter1, UIntPtr parameter2, long* a)
    {
        var l = a + parameter1;
    }
}