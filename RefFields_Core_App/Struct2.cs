namespace RefFields_Core_App;

public class Struct2
{
    
}

public ref struct RefStruct2
{
    Func<int> Example()
    {
        int number = Number;
        return () => number;
    }

    public delegate int PerformCalculation(ref int x, int y);

    public ref int Number;

    public static int DelegateMethod(ref int x, int y)
    {
        return 0;
    }

    public ref readonly int Test(scoped RefStruct2 buffer, ref int parameter)
    {
        PerformCalculation pc = (ref int i, int i1) => { return 1; };
        ref readonly int t = ref parameter;
        if (System.Runtime.CompilerServices.Unsafe.IsNullRef(ref Number))
        {
            throw new InvalidOperationException("The number ref field is not initialized.");
        }

        return ref t;
    }

    int Pc(ref int i, int i1)
    {
        return 1;
    }
}

public readonly unsafe ref struct ReadOnlyRefStruct2<T>
{
    readonly ref readonly T _field;

    public ReadOnlyRefStruct2(scoped ref T field)
    {
        _field = ref field;
    }
}