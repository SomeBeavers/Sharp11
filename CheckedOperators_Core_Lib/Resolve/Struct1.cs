namespace CheckedOperators_Core_Lib.Resolve;

public struct Struct1
{
    public static Struct1 operator --(Struct1 s1)
    {
        return default;
    }

    public static Struct1 operator checked --(Struct1 s1)
    {
        return default;
    }
}

public struct UseStruct1
{
    private void Test(Struct1 s1)
    {
        s1--;
        checked
        {
            s1--;
        }

        unchecked
        {
            s1--;
            Console.WriteLine(s1);
        }
    }
}