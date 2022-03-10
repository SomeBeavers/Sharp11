namespace Nuget
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class NugetAttribute<T,U> : Attribute where T: ParentClass where U : struct
    {
        public NugetAttribute()
        {
            
        }
    }

    public class ParentClass
    {
    }
}