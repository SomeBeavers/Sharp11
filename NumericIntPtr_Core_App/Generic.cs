namespace NumericIntPtr_Core_App;

public class Generic<T> where T:struct
{
    

}

public class UseGeneric
{
    public void Test(IntPtr[] array, UIntPtr[] array2)
    {
        Generic<nint> t = new Generic<IntPtr>();

        decimal intVar = array[0];
        double intVar2 = array2[0];
    }
}