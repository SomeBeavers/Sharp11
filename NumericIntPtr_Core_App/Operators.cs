namespace NumericIntPtr_Core_App;

public class Operators
{
    public IntPtr Test(IntPtr intPtr, UIntPtr uintPtr, MyStruct myStruct)
    {
        nint localNint = IntPtr.Zero;

        IntPtr[] array = new IntPtr[1];


        var operator1 = array[0] - intPtr;

        nint extensionMethod = intPtr.ExtensionMethod();

        var local1 = myStruct +(nint)uintPtr;

        if (extensionMethod == intPtr)
        {
            nint a = ~intPtr;

            nuint b = ~uintPtr;

            var uInt64 = uintPtr.ToUInt64();
        }


        return localNint;
    }
}

public static class Extensions
{
    public static nint ExtensionMethod(this IntPtr parameter)
    {
        return parameter--;
    }
}

public struct MyStruct
{
    public static MyStruct operator +(MyStruct a, nint b)
        => new();
}