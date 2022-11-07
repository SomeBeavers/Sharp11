using System.Linq.Expressions;

namespace UnsignedRightShift_Core_App;

public class Generic<T> where T : struct
{
    public void Test(long parameter, uint uintParameter, ulong ulongParameter, nint nintParameter, nuint nuintParameter)
    {
        var @ulong = ulongParameter>>> (int)parameter;
        var @ulong2 = ulongParameter >> (int)parameter;




        var @ulong3 = ulongParameter>>> (12);
        var foo = nintParameter >>> (int)@ulong;

        nuint foo1 = nuintParameter>> (int)uintParameter;
    }



    //var i = parameter>>> (int)parameter;
    //var i1 = 12 >>> 1;

    //uint i2 = uintParameter>>> (int)parameter;

    //var i3 = 13 >>> 1;
    //ulongParameter = ulongParameter>>> parameter;

    //Expression<Func<int, int, int>> z = (x, y) => x>>>y; 

}