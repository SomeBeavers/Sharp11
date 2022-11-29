namespace SAM_Core_App.Code;

public class Implementation: IImplementationInterface<Implementation>, IImplementationInterface2<Implementation>
{
    static Implementation _zero;

    public static Implementation Zero
    {
        get => _zero;
        set => _zero = value;
    }

    public static void AbstractMethod()
    {
    }

    public static string Name { get; set; }

    public static Implementation Addition()
    {
        return null;
    }

}

public interface IImplementationInterface<T> where T : IImplementationInterface<T>
{
    public static abstract T Zero { get; set; }

    public static abstract void AbstractMethod();

    public static virtual string Name { get; }

    static virtual T Addition()
    {
        return default;
    }
}

public record MyRecord: IImplementationInterface<MyRecord>
{
    static MyRecord IImplementationInterface<MyRecord>.Zero { get; set; }

    static void IImplementationInterface<MyRecord>.AbstractMethod()
    {
    }
}

public struct MyStruct: IImplementationInterface<MyStruct>
{
    public static MyStruct Zero { get; set; }
    public static void AbstractMethod()
    {
    }
}

public abstract class BaseClass : IImplementationInterface<BaseClass>
{
    public static BaseClass Zero { get; set; }
    public static void AbstractMethod()
    {
    }
}

public class BaseClassImpl : BaseClass
{
    public void Test()
    {
        var baseClass = BaseClassImpl.Zero;
    }
}

public interface IImplementationInterface2<T> where T : IImplementationInterface2<T>, new()
{
    public static abstract T Zero { get; set; }

    static virtual T Addition()
    {
        return new T();
    }
}

public class Use2<T> where T : IImplementationInterface<T>, new()
{
    public void Test(Implementation parameter, IDerivedInterface1 parameter2)
    {
        var zero = Implementation.Zero;
        var use2 = T.Zero;

        var derivedInterface1 = IDerivedInterface1.Addition();
    }
}

public partial interface IDerivedInterface1 : IImplementationInterface<IDerivedInterface1>
{
    static IDerivedInterface1 IImplementationInterface<IDerivedInterface1>.Zero
    {
        get => null;
        set { }
    }

    static void IImplementationInterface<IDerivedInterface1>.AbstractMethod()
    {
    }

    new static IDerivedInterface1 Addition()
    {
        return null;
    }

    public static virtual partial void Test();
}
public partial interface IDerivedInterface1 : IImplementationInterface<IDerivedInterface1>
{

    public static virtual partial void Test(){}

    public static extern virtual void Test2();
}

public interface IImplementationInterface3
{
    static abstract void Test();
    void Test2();
}


interface I0
{
    static sealed void M() => Console.WriteLine("Default behavior");
    
    
    static sealed int P1 { get; set; }

    static sealed event Action E1;
    static sealed event Action E2 { add => E1 += value; remove => E1 -= value; }
    
    static sealed I0 operator +(I0 l, I0 r) => l;
}

