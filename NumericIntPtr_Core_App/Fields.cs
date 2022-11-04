namespace NumericIntPtr_Core_App;

public class Fields
{
    public const IntPtr constIntPtr = 1;
    public const UIntPtr constUIntPtr = 1;

    static nint staticNint = IntPtr.Size;
    private static IntPtr staticIntPtr = new IntPtr();
    private static nuint staticUIntPtr = new UIntPtr();

    private readonly nint nintReadonlyField = new nint();

    public void Test()
    {
        IntPtr ptr = IntPtr.Zero;
    }
}