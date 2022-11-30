using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SAM_Core_App.Code;


class UseErrors
{
    public void Test()
    {
        
    }
}




public class Errors:IErrors<Errors>
{
    public static string AbstractProperty { get; set; }
    public static Errors AbstractMethod(List<Errors> list)
    {
        return null;
    }

    public static implicit operator Errors(string s)
    {
        return null;
    }

    public static explicit operator string(Errors t)
    {
        return null;
    }

    public static Errors operator ++(Errors t)
    {
        return null;
    }

    public static event Action<Errors>? Action;
}

public interface IErrors<T> where T : IErrors<T>
{
    public static abstract string AbstractProperty { get; set; }
    public static virtual string VirtualProperty
    {
        get { return null; }
        set { }
    }

    static abstract T AbstractMethod(List<T> list);

    static abstract implicit operator T(string s);
    public static abstract explicit operator string /*caret*/(T t);

    static abstract T operator ++(T t);
    static abstract event Action<T> Action;
}