namespace CheckedOperators_Core_Lib.Resolve1;

public class Class1
{
    public void Deconstruct(out int age)
    {
        age = Age;
    }

    public static Class1 operator +(Class1 cl1, Class1 cl2)
    {
        return new Class1 {Age = cl1.Age + cl2.Age};
    }

    public static Class1 operator checked +(Class1 cl1, Class1 cl2)
    {
        return null;
    }

    public static Class1 operator -(Class1 cl1, Class1 cl2)
    {
        return new Class1 {Age = cl1.Age - cl2.Age};
    }

    public static Class1 operator checked -(Class1 cl1, Class1 cl2)
    {
        return null;
    }


    public static explicit operator checked Class2(Class1 cl)
    {
        return new Class2();
    }

    public static explicit operator Class2(Class1 cl)
    {
        return new Class2();
    }

    public int Age { get; set; }
}

public class Class2
{
}

public class UseClass1
{
    private void Test(Class1 cl1, Class1 cl2)
    {
        checked
        {
            var class1 = cl1 + cl2;
            var class14 = cl1 + cl2;
            var class15 = cl1 + cl2;
        }
        var class12 = cl1 + cl2;
        unchecked
        {
            var class13 = cl1 + cl2;
        }
    }
}

interface I1<T> where T : I1<T>
{
    static abstract T operator checked -(T x);
    static abstract T operator -(T x);
}
class C : I1<C>
{
    public static C operator checked -(C x)
    {
        return null;
    }

    public static C operator -(C x)
    {
        return null;
    }
}