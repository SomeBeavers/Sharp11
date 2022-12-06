using System.Numerics;

namespace SAM_Core_App.Code;

public class Bug1
{
    static bool IsLessThan<T1, T2>(T1 v1, T2 v2) where T1 : IComparisonOperators<T1, T2, bool>
    {
        // No error
        return v1 < v2;
    }

    static bool IsLessThanBad<T1, T2>(T1 v1, T2 v2) where T1 : INumber<T1>, IComparisonOperators<T1, T2, bool>
    {
        // Error "Cannot apply operator '<' to operands of type 'T1' and 'T2'"
        return v1 < v2;
    }

    int CalculateBetween<T1, T2>(T1 v1, T2 v2) where T1 : INumber<T1>, IAdditionOperators<T1, T2, T1>, ISubtractionOperators<T1, T2, T1>
    {
        // No error
        var subtractionOperators = v1 - v2;

        return 1;
    }

    public static int ToInt<T>(T value) where T : INumberBase<T>
    {
        return int.CreateTruncating(value);
    }


    public static void Test<T>(T parameter) where T: IBinaryNumber<T>
    {
        Func<T, bool> isZero = T.IsZero;
        int.CreateChecked(parameter);
    }

}

