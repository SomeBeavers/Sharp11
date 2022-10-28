// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var s = "a"u8;

var mystring = "mystring"u8;

ReadOnlySpan<byte> LocalFunc()
{
    var readOnlySpan = ""u8;
    Console.WriteLine(readOnlySpan.ToString());
    return readOnlySpan;
}

//new MyRecord(""u8);

//record MyRecord(ReadOnlySpan<byte> ReadOnlySpan)
//{

//}