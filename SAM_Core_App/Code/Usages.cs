namespace SAM_Core_App.Code;

public class Usages<T> where T: IUsage1
{
    public void Test(T t)
    {
        T.Usage2();
        T.Usage1();
    }
}

public interface IUsage1
{
    static virtual void Usage2()
    {
    }

    static virtual void Usage1()
    {
        //Usage2();
    }
}