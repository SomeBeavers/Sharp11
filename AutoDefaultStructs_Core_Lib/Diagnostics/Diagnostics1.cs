namespace AutoDefaultStructs_Core_Lib.Diagnostics;

public struct Diagnostics1
{
    // ReSharper disable once NotAccessedField.Local
    private readonly string s;
#pragma warning disable CS0169
    private int t;
#pragma warning restore CS0169

    public Diagnostics1(string s)
    {
        this.s = s;
    }
}

struct S
{
    private int x1;

    public int X
    {
        get => x1;
        set => x1 = x1 < value ? value : x1;
    }

    public S() // error: backing field of 'S.X' is implicitly initialized to 'default'.
    {
        X = 1;
    }
}