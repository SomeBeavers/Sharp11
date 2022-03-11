namespace GenericAttributes_Core
{
    public class ImportCompletion
    {
        private void Test()
        {
        }
    }
}

namespace MyNamespace
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class Nuget1Attribute<T, U> : Attribute where T : ParentClass where U : struct
    {
        public Nuget1Attribute()
        {

        }
    }

    public class ParentClass
    {
    }
}