using System.Linq.Expressions;

namespace utf8_Core_App.Code;

//record MyRecord(ReadOnlySpan<byte> ReadOnlySpan)
//{

//}

//[My(""U8)]
public class Errors
{

    //const ReadOnlySpan<byte> x = "abc";

    //void M(Span<byte> x = "abc"u8){}

    public void Test(ReadOnlySpan<byte> parameter)
    {
        //const string text = "hello \uD801\uD802";
        //foreach (var b in "hello \uD801\uD802"u8)
        //{
        //    Console.WriteLine(b);
        //}
    }

    public void Test2()
    {
        ReadOnlySpan<byte> text = "hello"u8 +
                                  "a"u8
                                  +"턑\\dddd"u8 +
                                  "uD802"u8;
    }

    public void MethodWithOptionalParameter(ReadOnlySpan<byte> s
    //= ""u8
    )
    {

    }
    public void MethodWithOptionalParameter2(byte[] s
    //= ""u8
    )
    {
        //s = ""u8;
    }

    public void Lambdas()
    {
        var x = static () => "hello"U8;           // () => new [] {104, 101, 108, 108, 111}
        //Expression<Func<Span<byte>>> y = () => "dog"u8;           // () => new Span`1(new [] {100, 111, 103}) 
        //Expression<Func<ReadOnlySpan<byte>>> z = () => "cat"u8;   // () => new ReadOnlySpan`1(new [] {99, 97, 116})

        
    }

    public ReadOnlySpan<byte> Lambdas2()
    {
        var u81 = "test"u8;
        Console.WriteLine(u81.ToString());
        var readOnlySpan = "a"U8;


        var newString = $"{u81.ToString()}"+
                        "";

        return u81;
    }
    //
}

public class MyAttribute : Attribute
{
    public MyAttribute(ReadOnlySpan<byte> parameter)
    {
    }
    public MyAttribute(string parameter)
    {
    }
}