namespace RefFields_Core_App;

public interface IScopedParameters
{
    void Test(in int t, ref RefStruct2 parameter);
}

class ScopedParameters2 : IScopedParameters
{
    public void Test(in int t, scoped ref RefStruct2 parameter)
    {
        scoped Span<char> escapedPropertyName;
        scoped Span<int> escapedPropertyValue;

    }
}

public abstract class ScopedParameters : IScopedParameters
{
    public abstract void Test(in int t, ref RefStruct2 parameter);
}

//class ScopedParametersImpl : ScopedParameters
//{
//    public override void Test(in int t, ref RefStruct2 parameter)
//    {
//    }

//    public ref RefStruct2 Test2(scoped ref RefStruct2 parameter)
//    {
//        ref var localFunction = ref LocalFunction(ref parameter);

//        ref RefStruct2 LocalFunction(ref RefStruct2 refStruct2)
//        {
//            return ref refStruct2;
//        }


//        return ref localFunction;
//    }

//}