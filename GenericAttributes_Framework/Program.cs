using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes_Framework
{
    internal class Program
    {
        [Generic<Program>]
        static void Main(string[] args)
        {
        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class GenericAttribute<T> : Attribute
    {
    }
}
