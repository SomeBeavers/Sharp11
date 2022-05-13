namespace CheckedOperators_Core_Lib.Resolve;

public record Record1(string Name, int Age)
{
    public static Record1 operator checked +(Record1 r1, byte t)
    {
        return new Record1(r1.Name,
            r1.Age + t);
    }

    public static Record1 operator +(Record1 r1, byte t)
    {
        return null;
    }

    public static Record1 operator +(Record1 r1, int t)
    {
        return null;
    }
}

public record UseRecord1(Record1 R1, Record1 R2)
{
    private void Test()
    {
        var r1 = checked(R1 + 10);
        var r2 = unchecked(R1 + 10);
    }
}