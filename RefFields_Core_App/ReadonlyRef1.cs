namespace RefFields_Core_App;

ref struct ReadOnlyExample
{
    ref readonly int Field1;
    readonly ref int Field2;
    readonly ref readonly int Field3;

    public ReadOnlyExample(ref int field2)
    {
        Field2 = ref field2;
    }

    void Uses(int[] array)
    {
        //Field1 = ref array[0];  // Okay
        //Field1 = array[0];      // Error: can't assign ref readonly value (value is readonly)
        //Field2 = ref array[0];  // Error: can't repoint readonly ref
        //Field2 = array[0];      // Okay
        //Field3 = ref array[0];  // Error: can't repoint readonly ref
        //Field3 = array[0];      // Error: can't assign ref readonly value (value is readonly)
    }
}

readonly ref struct ReadOnlyRefStruct
{
    readonly ref readonly int t;
    
}

readonly ref struct Span1<T>
{
    readonly ref T _field;
    readonly int _length;

    public Span1(ref T value)
    {
        // Falls into the `x.e1 = ref e2` case, where `x` is the implicit `this`. The 
        // safe-to-escape of `this` is *return only* and ref-safe-to-escape of `value` is 
        // *calling method* hence this is legal.
        _field = ref value;
        _length = 1;
    }
}



//ref struct RS
//{
//    ref int _refField;
//    int _field;

//    // Okay: this falls into bullet one above. 
//    public ref int Prop1 => ref _refField;

//    // Error: This is bullet four above and the ref-safe-to-escape of `this`
//    // in a `struct` is the current method scope.
//    public ref int Prop2 => ref _field;
//}