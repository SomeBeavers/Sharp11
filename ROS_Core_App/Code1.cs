namespace ROS_Core_App;
#nullable disable
public class Code1
{
    const string nullString = null;
    const string defaultString = default;
    const string constString = "aaaaa";

    public void Test(ReadOnlySpan<char> ros, Span<char> span)
    {
        switch (ros)
        {
            /*or defaultString*/
            case "Hello, World!" or "test":
                Console.WriteLine("Hello, World!");
                break;
            case "":
                Console.WriteLine("Span is whitespace");
                break;
            //case nullString:
            //    Console.WriteLine("Span is null");
            //    break;
        }

        var s1 = span switch
        {
            "Hello, World!" => "",
            "" => "",
            //not defaultString => "",
        };

        var array = ros.ToArray().Where(x => x.ToString() == "a").ToArray();
    }

    static bool IsEmpty(ReadOnlySpan<char> span)
    {
        return span switch
        {
            constString => true,
            """
    {defaultString}
    """ => // error: unreachable?
                true,
            "" => // error: unreachable?
                true,
            _ => false,
        };
    }
}