using Referenced_Core;

namespace GenericAttributes_Core;

public class UseReferenced
{
    [ReferencedGeneric<MyParameter>("MyParameter")]
    private void Test(MyParameter myParameter)
    {
    }

    private const MyParameter MyParameter = null!;
}

public class MyParameter
{
    public MyParameter()
    {
    }
}