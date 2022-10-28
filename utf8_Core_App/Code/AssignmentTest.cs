namespace utf8_Core_App.Code;

public ref struct AssignmentTest
{
    public Span<byte> field;

    public ReadOnlySpan<byte> field2;

    //public const ReadOnlySpan<byte> field3 = ""U8;
    public readonly ReadOnlySpan<byte> field4;


    public AssignmentTest(ReadOnlySpan<byte> field4)
    {
        this.field4 = Property1;
        this.field4 = field4;
    }

    private static ReadOnlySpan<byte> Property1 => ""u8;

    public object U8 { get; private set; }

    public ReadOnlySpan<byte> MethodReturn()
    {
        //return "Property1"U8;
        return Property1;
    }

    public ReadOnlySpan<byte> FieldReturn(Span<byte> parameter)
    {
        var span = ""u8;
        Method2(ref span);
        //return parameter = ""U8;
        return parameter;
    }


    public void Method2(ref ReadOnlySpan<byte> parameter)
    {
        parameter = "test"U8;
        field2 = new ReadOnlySpan<byte>(""u8.ToArray());
    }

    public void Test()
    {
        //var myRecord = new MyRecord(""u8);

        ""u8.CopyTo(field);
        field2 = "some string"u8;
    }
}

//record MyRecord
//{
//    public MyRecord(ReadOnlySpan<byte> RecordProperty)
//    {
//        this.RecordProperty = RecordProperty;
//    }

//    public ReadOnlySpan<byte> RecordProperty { get; init; }

//    public void Deconstruct(out ReadOnlySpan<byte> RecordProperty)
//    {
//        RecordProperty = this.RecordProperty;
//    }
//}