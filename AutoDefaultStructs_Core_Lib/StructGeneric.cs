using System.Runtime.CompilerServices;

namespace AutoDefaultStructs_Core_Lib;

public partial struct StructGeneric<T> where T: new()
{
    private T? tField;
    public T Name;


    public StructGeneric(UseStructGeneric useStructGeneric, T? tField) : this(tField)
    {
    }

    private StructGeneric(T? tField)
    {
        this.tField = tField;
    }
}


public class UseStructGeneric
{
    private void Test(string s)
    {

    }
}