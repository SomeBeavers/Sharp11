namespace AutoDefaultStructs_Core_Lib;

public struct PropertyStruct
{
    private MyProp? myPropNullable;
    private readonly MyProp myPropNotNullable;

    public PropertyStruct()
    {
    }

    public PropertyStruct(MyProp myPropNotNullable, bool b)
    {
        if (b)
        {
            this.myPropNotNullable = myPropNotNullable;
        }
        else
        {
            this.myPropNullable = myPropNotNullable;
        }
    }

    public MyProp? MyProp_Nullable
    {
        readonly get => myPropNullable;
        set => myPropNullable = value;
    }

    public MyProp MyProp_NotNullable
    {
        readonly get => myPropNotNullable;
        init => myPropNotNullable = value;
    }

    private void Test()
    {
        var propertyStruct = new PropertyStruct { MyProp_NotNullable = new MyProp() };
    }
}

public class MyProp
{
}

public class UsePropertyStruct
{
    private void Test(PropertyStruct ps)
    {
        var propertyStruct = new PropertyStruct(null!,
            false);
        new PropertyStruct();

    }
}