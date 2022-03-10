namespace GenericAttributes_Core;

public class GenericClass<T>
{
    //[SomeAttribute<T>]
    public void DoSomething(T input)
    {
    }
}

public class SomeAttribute<T> : Attribute
{

}

