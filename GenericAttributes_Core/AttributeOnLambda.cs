namespace GenericAttributes_Core;

public class AttributeOnLambda
{
    private void Test()
    {
        Test2([GenericOnLambda<string>]() => new AttributeOnLambda());
        Test2([GenericOnLambda<NewClassOnLambda>]() => new AttributeOnLambda());
        Test2([return:GenericOnLambda<int>]() => new AttributeOnLambda());
    }

    private void Test2(Func<AttributeOnLambda> func)
    {
        throw new NotImplementedException();
    }
}

internal class NewClassOnLambda
{
}

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
sealed class GenericOnLambdaAttribute<T> : Attribute
{
    // See the attribute guidelines at 
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    public GenericOnLambdaAttribute()
    {
        // TODO: Implement code here
        throw new NotImplementedException();
    }
}