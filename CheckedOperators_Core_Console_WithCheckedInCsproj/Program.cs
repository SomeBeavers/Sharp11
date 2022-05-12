var myClass = new MyClass();
var s = myClass + new A();
var @class = checked(myClass + myClass);


class MyClass: A
{
    public static MyClass operator +(MyClass m1, MyClass t)
    {
        return null;
    }
}

internal class A
{
    public static A operator checked +(A m1, A m)
    {
        return new A();
    }

    public static A operator +(A m1, A m)
    {
        return null;
    }
}
