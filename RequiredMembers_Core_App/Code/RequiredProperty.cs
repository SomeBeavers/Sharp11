using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

internal abstract class RequiredProperty
{
    //[SetsRequiredMembers]
    public RequiredProperty(string name)
    {
        //Name = name;
    }


    internal required InnerType InnerTypeProperty { get; set; }

    internal class InnerType
    {
        internal required int requiredField;
        internal required string innerTypeName;

        public required string InnerTypeName
        {
            get => innerTypeName;
            internal set => innerTypeName = value;
        }
    }

    public abstract required string Name { get; set; }
}

class RequiredPropertyImpl : RequiredProperty
{
    //[SetsRequiredMembers]
    public RequiredPropertyImpl(string name) : base(name)
    {
    }

    public override required string Name
    {
        get => null;
        set { }
    }
}

public class UseRequiredProperty
{
    public void Test()
    {
        var requiredProperty = new RequiredPropertyImpl("")
        {
            Name = "null",
            InnerTypeProperty = new()
            {
                requiredField = 0,
                InnerTypeName = null,
                innerTypeName = null
            }
        };
    }
}