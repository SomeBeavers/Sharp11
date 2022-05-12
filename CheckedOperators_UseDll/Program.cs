using CheckedOperators_Core_Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedOperators_UseDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private  void Test(Overload1 o1)
        {
            checked
            {
                var s = o1++;
                var s2 = o1++;
            }
        }
    }
}
