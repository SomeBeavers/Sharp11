namespace RefFields_Core_App;

public ref struct Struct1
{
    ref int t;
    ref int t2;
    readonly ref int t3;
    ref readonly int t4;
    readonly ref readonly int t5;

    /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
    public Struct1(int t, int t2, int t3, int t4, int t5)
    {
        this.t = t;
        this.t2 = t2;
        this.t3 = t3;
    }

    static void DoStuffWithBuffer(scoped ref byte[] buffer) { }

}