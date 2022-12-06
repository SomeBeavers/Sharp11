var span = new ReadOnlySpan<char>();

switch (span)
{
    case "Hello, World!":
        Console.WriteLine("Hello, World!");
        break;
    case "":
        Console.WriteLine("Span is whitespace");
        break;
    default:
        Console.WriteLine("Span is not empty");
        break;
}

if (span == "Hello, World!")
{
    Console.WriteLine("Hello, World!");
}
else if (span == "")
{
    Console.WriteLine("Span is whitespace");
}
else
{
    Console.WriteLine("Span is not empty");
}