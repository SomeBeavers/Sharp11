namespace RefFields_Core_App;

public class Generic<T> where T : IComparable
{
    public GenericStruct<T> Test(/*scoped*/ GenericStruct<T> buffer, ref T parameter)
    {
        ref readonly T t = ref parameter;

        buffer.RefArray[0] = t;

        var compareTo = buffer.RefArray[1].CompareTo(t);

        return buffer;
    }
}

public ref struct GenericStruct<T> where T : IComparable
{
    public ref T[] RefArray;
    public ref readonly T Test(ref T comparable)
    {
        return ref comparable;
    }

    public void Test2(ref T comparable)
    {
        RefArray = new T[2];  
        //return ref this;
    }

}