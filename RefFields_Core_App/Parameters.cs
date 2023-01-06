namespace RefFields_Core_App;

public class Parameters
{
    Span<int> Read(Span<byte> buffer, out int read)
    {
        // .. 
        read = 0;
        return default;
    }

    Span<int> Use(ref byte value)
    {
        Span<byte> buffer = new Span<byte>(ref value);

        // If we keep current `out` ref-safe-to-escape this is an error. The language must consider
        // the `read` parameter as returnable as a `ref` field
        //
        // If we change `out` ref-safe-to-escape this is legal. The language does not consider the 
        // `read` parameter to be returnable hence this is safe
        int read;
        return Read(buffer,
            out read);
    }

    public void Test(ref int t, in int t2, out int t3)
    {
        t3 = 0;
    }
}


public ref struct Struct3<T>
{
    public ref T[] refArray;
    ref readonly T test(ref T parameter)
    {
        return ref parameter;
    }
}