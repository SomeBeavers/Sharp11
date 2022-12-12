
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROS_Framework
{
    public class Class1
    {
        public void Test(ReadOnlySpan<char> c)
        {
            if (c is "Hello, World!")
                Console.WriteLine("Hello, World!");
            else if (c is "")
                Console.WriteLine("Span is whitespace");
            else
                Console.WriteLine("Span is not empty");
        }
    }
}
