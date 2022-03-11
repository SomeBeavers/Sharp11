namespace GenericAttributes_Core;

//[GenericErrors<T>]
public class Errors<T>
{
    void Test()
    {
    }
}

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
sealed class GenericErrorsAttribute<TGenericParameter> : Attribute
{
}
//[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
//sealed class GenericErrors<TGenericParameter> : Attribute
//{
//}