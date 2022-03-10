namespace GenericAttributes_Core;

[AttributeWithUsage<string>]
[AttributeWithUsage<int>]
public class WithAttributeUsage
{
    //[AttributeWithUsage<string>]
    private void Test()
    {
    }
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
class AttributeWithUsageAttribute<T>: Attribute
{
    
}