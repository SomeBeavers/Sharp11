namespace GenericAttributes_Core2;

[DerivedGeneric<MyStruct>]
[GenericAttribute<MyStruct>]
public class Inheritance
{
    private void Test()
    {
        new DerivedGenericAttribute<MyStruct>();
    }
}

public struct MyStruct
{
}

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
class GenericAttribute<T> : Attribute where T: struct
{
}

class DerivedGenericAttribute<T> : GenericAttribute<T> where T : struct
{
}