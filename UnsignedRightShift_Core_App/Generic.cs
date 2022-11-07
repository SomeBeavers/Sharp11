namespace UnsignedRightShift_Core_App;

public class Generic<T> where T : struct
{
    public void Test()
    {
        var i = (12>>> 1) + 3;
        var i1 = 12 >> 1;
    }
}