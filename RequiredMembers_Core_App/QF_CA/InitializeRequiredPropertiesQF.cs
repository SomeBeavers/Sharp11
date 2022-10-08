using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.QF_CA;

internal class InitializeRequiredPropertiesQF
{
    public readonly int ReadonlyFiled2;
    internal required int ReadonlyFiled;

    //[SetsRequiredMembers]
    public InitializeRequiredPropertiesQF()
    {
        MyStringProperty = "";
    }

    public string MyStringProperty { get; set; }

    public required InnerType InnerTypeProperty { get; set; }

    public class InnerType
    {
        public required string Name { get; set; }
    }
}



public class UseInitializeRequiredPropertiesQF
{
    public void Test()
    {
        InitializeRequiredPropertiesQF initializeRequiredPropertiesQf = new()
        {
            ReadonlyFiled = 0,
            InnerTypeProperty = new()
            {
                Name = "null"
            },
            MyStringProperty = null
        };
    }
} 