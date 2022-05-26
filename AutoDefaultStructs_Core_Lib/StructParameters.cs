namespace AutoDefaultStructs_Core_Lib;

public struct StructParameters
{
    private UseStructParameters useStructParameters;
    private int t;

    public StructParameters(out UseStructParameters structParameters)
    {
        structParameters = null;
    }
}

public class UseStructParameters
{
    private void Test(out string s)
    {
        var useStructParameters = new UseStructParameters();
        var structParameters = new StructParameters(out useStructParameters);
        s = null;
    }
}