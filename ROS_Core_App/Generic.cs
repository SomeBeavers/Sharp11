using System.Linq.Expressions;

namespace ROS_Core_App;

public class Generic<T>
{
    public void Test(Span<T> span, ReadOnlySpan<T> ros)
    {
        //switch (span)
        //{
        //    case "Hello, World!":
        //        Console.WriteLine("Hello, World!");
        //        break;
        //    case string and "":
        //        Console.WriteLine("Span is whitespace");
        //        break;
        //    case string and "bbb":
        //        Console.WriteLine("Hello, World!");
        //        break;
        //}

        //switch (ros)
        //{
        //    case "Hello, World!":
        //        Console.WriteLine("Hello, World!");
        //        break;
        //}
    }
}

public ref struct Generic2<T>
{
    public Span<T> Span { get; set; }
}

public class UseGeneric
{
    public void Test(Generic2<char> g2)
    {
        var b = g2.Span is Span<char> and "ABC";

        switch (g2)
        {
            case {Span: ""}:
                break;
        }
    }
}