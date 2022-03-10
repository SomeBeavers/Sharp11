namespace GenericAttributes_Core;

public class UseGenericPartial
{
    [GenericPartial<CreatedClass, int>]
    private void Test()
    {
    }
}

internal class CreatedClass
{
    public CreatedClass(string s)
    {
    }

    public CreatedClass()
    {
        throw new NotImplementedException();
    }
}