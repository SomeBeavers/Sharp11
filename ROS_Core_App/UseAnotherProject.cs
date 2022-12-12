using ROS_Core_Lib;

namespace ROS_Core_App;

public class UseAnotherProject
{
    public void Test(UseMe useMe)
    {
        if (useMe.Span is "null")
        {
            Console.WriteLine("Span is null");
        }
        else if (useMe.Span is "")
        {
            Console.WriteLine("Span is whitespace");
        }
        else if (useMe.Span is "Hello, World!")
        {
            Console.WriteLine("Hello, World!");
        }
        else if (useMe.Span != "")
        {
            Console.WriteLine("Span is not empty");
        }
        else if (useMe.Span is "bbb")
        {
            Console.WriteLine("Hello, World!");
        }
    }
}