namespace ListPatterns_Core_App.QF;

public class QF2
{
    public void Test(ListType<D[]> collection)
    {
        switch (collection)
        {
            case
            [
                .. var s,
                [
                    { Name: "test" },
                ],
            ]:
                break;
        }
    }
}

public class D
{
    public string Name { get; set; }
}

public class ListType<T>
{
    private T[] arr;
    public int Length { get; set; }

    public T this[int i]
    {
        get => arr[i];
        set => arr[i] = value;
    }

    public T[] Slice(int start, int length)
    {
        var slice = new T[length];
        Array.Copy(arr,
            start,
            slice,
            0,
            length);
        return slice;
    }
}