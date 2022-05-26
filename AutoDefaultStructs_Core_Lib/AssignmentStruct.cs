using System.Security.Cryptography;

namespace AutoDefaultStructs_Core_Lib;

public struct AssignmentStruct
{
    private MyField? myField;

    public AssignmentStruct(MyField myField)
    {
        this = new AssignmentStruct();
    }
}

public class MyField
{
}

public class UseAssignmentStruct
{
    private void Test()
    {

    }
}