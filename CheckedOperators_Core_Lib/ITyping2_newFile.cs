#nullable disable
namespace CheckedOperators_Core_Lib;

public interface ITyping2
{
    public static ITyping2 operator ++(ITyping2 t1)
    {
        return null;
    }

    public void Test()
    {
    }

    public static ITyping2 operator checked ++(ITyping2 t1)
    {
        return null;
    }

    public static ITyping2 operator --(ITyping2 t1)
    {
        return null;
    }
}