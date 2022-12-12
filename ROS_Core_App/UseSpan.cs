namespace ROS_Core_App;

public ref struct UseSpan
{
    public Span<char> Span { get; set; }

    public void Test()
    {
        if (Span is "Hello, World!")
        {
            Console.WriteLine("Hello, World!");
        }
        else if (Span is "")
        {
            Console.WriteLine("Span is whitespace");
        }
    }
}