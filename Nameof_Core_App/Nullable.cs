using System.Diagnostics.CodeAnalysis;

namespace Nameof_Core_App;

public class Nullable
{
    class Path
    {
        [return: NotNullIfNotNull(nameof(path))] // This fails to compile, needs to be "path" instead
        public static string? GetFileName(string? path)
        {
            return null;
        }

        [My(nameof(thisParameter))]
        public static void AnotherMethod(int thisParameter)
        {
        }
    }

    class A : System.Attribute
    {
        public A(int i, string s) { }
    }

    class C
    {

        [Attr(nameof(p))] 
        void M(int p) { }
        const int item1 = 123;
        int item2;

        [A(item1, nameof(C.item2))]
        void M(int item1, int item2) { }
    }

    internal class AttrAttribute : Attribute
    {
        public AttrAttribute(string pName)
        {
        }
    }
}

