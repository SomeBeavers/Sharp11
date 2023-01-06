namespace RefFields_Core_App;

public class ReadonlyRef2
{
    public void Test(ref int parameter)
    {
        var ref2Struct = new ReadonlyRef2_Struct { t3 = ref parameter };

        //ref2Struct.t4 = ref parameter;
        //ref2Struct.t3 = 1;
    }
}

public ref struct ReadonlyRef2_Struct
{
    public readonly ref int t;
    public readonly ref int t2;

    public ref readonly int t3;
    public readonly ref readonly int t4;

    public int MyProperty
    {
        readonly get => t;
        init
        {
            //t3 = value;
            t4 = ref t2;
        }
    }

    public ReadonlyRef2_Struct(int t)
    {
        this.t = t;
    }

    public readonly ref int Test(ref int parameter)
    {
        //this.t = ref parameter;
        //t3 = 1;
        ref int t = ref parameter;
        return ref t;
    }
}