namespace SAM_Core_App.Code;

public class Play: IPlay1<Play>, IPlay2<Play>
{
    static void IPlay1<Play>.Test()
    {
        Test();
    }

    static void IPlay2<Play>.Test()
    {
        Test();
    }

    public static void Test()
    {
        Console.WriteLine("Test");
    }

    static Play IPlay1<Play>.operator +(Play left, Play right)
    {
        return left + right;
    }


    public static Play operator +(Play left, Play right)
    {
        return null;
    }
}

public interface IPlay1<T> where T : IPlay1<T>
{
    static abstract void Test();


    static virtual T operator +(T left, T right)
    {
        return left + right;
    }
}
public interface IPlay2<T> where T : IPlay2<T>
{

    static abstract void Test();

    static virtual T operator +(T left, T right)
    {
        return left + right;
    }
}