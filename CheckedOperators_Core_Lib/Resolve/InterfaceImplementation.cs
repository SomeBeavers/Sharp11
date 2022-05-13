namespace CheckedOperators_Core_Lib.Resolve;
#nullable disable
public interface IInterfaceImplementation
{
    public static IInterfaceImplementation operator checked ++(IInterfaceImplementation im)
    {
        return new InterfaceImplementation();
    }

    public static IInterfaceImplementation operator ++(IInterfaceImplementation im)
    {
        return null;
    }
}

class InterfaceImplementation2 : IInterfaceImplementation
{
}

public class InterfaceImplementation : IInterfaceImplementation
{
    public static InterfaceImplementation operator checked ++(InterfaceImplementation um1)
    {
        return new InterfaceImplementation();
    }


    public static InterfaceImplementation operator ++(InterfaceImplementation um2)
    {
        return null;
    }

    /// <summary>
    /// comment <see cref="op_CheckedIncrement"/> <see cref="op_Increment"/>
    /// </summary>
    /// <returns></returns>
    private void Test()
    {
    }
}

public class Use
{
    private void Test()
    {

    }
}