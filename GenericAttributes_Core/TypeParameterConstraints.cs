using MyNamespace;

namespace GenericAttributes_Core3
{
    [GenericFromMyNamespace<GenericFromMyNamespace2Attribute>]
    public class TypeParameterConstraints
    {
    
    }
    class GenericFromMyNamespace34Attribute
    {
    }
}

namespace MyNamespace
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    internal sealed class GenericFromMyNamespaceAttribute<T> : Attribute where T : Attribute
    {
    }

    internal sealed class GenericFromMyNamespace2Attribute: Attribute
    {
    }

    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class WithConstraintsAttribute<TTest> : Attribute
    {
    }
}