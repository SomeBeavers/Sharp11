using RefFields_Core_Lib;

namespace RefFields_Core_App;

public class UseReferencedStruct1
{
    public int Test()
    {
        var referencedStruct1 = new ReferencedStruct1();
        referencedStruct1.MyRefField = 1;

        return referencedStruct1.MyRefField;
    }
}