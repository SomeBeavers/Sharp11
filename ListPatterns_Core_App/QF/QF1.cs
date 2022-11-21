namespace ListPatterns_Core_App.QF;

public class QF1
{
    private const A<string> a = null;
    private const string constString = "";

    public void ConvertToSwitch(A<string>[] parameters, string name)
    {
        //if (parameters is [not null,var z, [constString, not null], .. var x])
        //{
        //    Console.WriteLine(z?.Name);
        //}

        if (parameters.Length == 3 && parameters[0] is { } && parameters[1] is var y && parameters[2] is var s)
            Console.WriteLine(y?.Name);

        if (parameters is [{ }, var y1, var s2, .. var x]) Console.WriteLine(y1?.Name);
    }
}

public class A<T>
{
    private readonly T[] arr = new T[100];
    public int Count { get; set; }
    public string Name { get; set; }

    public T this[int i]
    {
        get => arr[i];
        set => arr[i] = value;
    }
}

internal class SampleCollection<T>
{
}