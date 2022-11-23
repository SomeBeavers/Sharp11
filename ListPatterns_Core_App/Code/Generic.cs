namespace ListPatterns_Core_App.Code;

public class Generic<T> where T : IT, new()
{
    public void Test(T[] collection)
    {
        if (collection.Length == 2 && collection[0] is InnerType innerType)
        {
        }
    }
}

public interface IT
{
    public string Name { get; set; }
    public int Age { get; set; }
}

internal class GenericImpl<T> : Generic<T> where T : IT, new()
{
    public T[] collection;

    public T GetT
    {
        get => collection switch
        {
            [{ Name: not null and "" }, .., { Name: "Jane Doe" }, { } t, {Age: not > 42}] => t,
            not null => new T()
        };
        set { }
    }

    public void Lambda(T[][] collection, int[] collection2)
    {
        var count = collection.Count(static x => x is [null, { Name: not null }, .. var s]);
    }
}