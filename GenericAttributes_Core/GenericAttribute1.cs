namespace GenericAttributes_Core;

[Generic<string>("")]
[NormalAttribute("")]
public class GenericAttribute1
{
    private void Test()
    {
        new GenericAttribute<string>("");
        new NormalAttribute("");
    }
}

class GenericAttribute<T>: Attribute
{
    public GenericAttribute(T genericParameter)
    {
    }
}
class NormalAttribute: Attribute
{
    public NormalAttribute(string s)
    {
    }
}