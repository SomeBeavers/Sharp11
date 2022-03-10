namespace GenericAttributes_Core;

public record UseNuget();

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
sealed class TestAttribute<T> : Attribute
{
    // See the attribute guidelines at 
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    public TestAttribute()
    {
        // TODO: Implement code here
        throw new NotImplementedException();
    }
}