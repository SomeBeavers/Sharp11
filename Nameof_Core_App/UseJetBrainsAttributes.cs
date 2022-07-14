using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Nameof_Core_App;

public class UseJetBrainsAttributes
{
    public void Test([NotNullIfNotNull(nameof(anotherParameter))]string? myParameter, string? anotherParameter)
    {

    }

    void Function(int a, TimeSpan b, 
        [CallerArgumentExpression(nameof(a))] string c = "", 
        [CallerArgumentExpression(nameof(b))] string d = "")
    {
        Console.WriteLine($"Called with value {a} from expression '{c}'");
        Console.WriteLine($"Called with value {b} from expression '{d}'");
    }
}