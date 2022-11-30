namespace SAM_Core_App.QF_CA;

public class QF1<T> where T:IQF
{
    public void Test(T t)
    {
        T.Method("test");
        //IQF.Method();
    }
}

public interface IQF
{
    public static abstract void Method(string s);
}

class Qf : IQF
{
    public static void Method(string s)
    {
    }
}

public interface IQF2 : IQF
{
    new static void Method(string s)
    {
    }
}