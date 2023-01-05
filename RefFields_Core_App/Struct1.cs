namespace RefFields_Core_App;

public ref struct Struct1
{
    ref int t;
    ref int t2;
    readonly ref int t3;
    ref readonly int t4/*caret*/;
    readonly ref readonly int t5;

    public Struct1(int t, int t2, out int t4)
    {
        this.t = t;
        this.t2 = t2;
        t4 = 0;
    }

    static void DoStuffWithBuffer(scoped ref byte[] buffer) { }
}

readonly ref struct Span<T>
{
    readonly ref T _field;
    readonly int _length;

    // This constructor does not exist today but will be added as a part 
    // of changing Span<T> to have ref fields. It is a convenient, and
    // safe, way to create a length one span over a stack value that today 
    // requires unsafe code.
    public Span(ref T value)
    {
        _field = ref value;
        _length = 1;
    }
}

public ref struct RefFieldExample
{
    private ref int number;

    public int GetNumber()
    {
        if (System.Runtime.CompilerServices.Unsafe.IsNullRef(ref number))
        {
            throw new InvalidOperationException("The number ref field is not initialized.");
        }

        return number;
    }
}

public readonly ref struct MySpan<T> where T: class
{
    internal readonly ref T _field;
    private readonly int _length;

    // Omitted for brevity...
}

ref struct S1 
{
    private ref int Value;
    readonly int t;

    public int GetValue()
    {
        if (System.Runtime.CompilerServices.Unsafe.IsNullRef(ref Value))
        {
            throw new InvalidOperationException("");
        }

        return Value;
    }
}