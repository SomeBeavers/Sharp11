namespace RequiredMembers_Core_App.Code;

public struct MyStruct2
{
    public MyStruct2(string requiredProp)
    {
        RequiredProp = requiredProp;
    }

    public required string RequiredProp;
}

public class UseMyStruct2
{
    public void Test()
    {
        var myStruct2 = new MyStruct2("")
        {
            RequiredProp = null
        };
    }
}