namespace Referenced_Core;

public class ReferencedGenericAttribute<T>: Attribute
{
    public ReferencedGenericAttribute(string parameter)
    {
        Console.WriteLine(parameter);
    }
}