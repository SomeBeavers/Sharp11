using System.Runtime.CompilerServices;

namespace Nameof_Core_App;

[GenericAttribute(nameof(T))]
public class GenericNameof<T> where T: class
{

    [Generic(nameof(U), nameof(genericParameter))]
    private void GenericMethod1<U>(U genericParameter)
    {
    }

    private void MethodWithManyParameters(
        [Generic(nameof(second))]int first,
        [Generic(nameof(third), nameof(first))]int second,
        [Generic(nameof(third))]string third = null)
    {
    }

    private const string notDefinedParameter = "VALUE";
}

public class GenericAttribute : Attribute
{
    public GenericAttribute(string nameofParameter)
    {
    }

    public GenericAttribute(string nameofParameter1, string nameofParameter2)
    {
    }
}