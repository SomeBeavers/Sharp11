namespace ListPatterns_Core_App.Code;

public class AllTypesOfCollection
{
    private const string MyConst = "const string";

    private const int constInt1 = 1;
    private const int constInt2 = 1;

    private const int[] constArray = null;
    private const int[] constArray2 = null;
    private const Animal[] O = null;

    public void Test1(
        List<int> simpleList,
        List<ListType<string>> notSimpleList,
        int[] simpleArray,
        int[][] notSimpleArray,
        Dictionary<string, string> simpleDictionary,
        Dictionary<int, Animal[]> notSimpleDictionary,
        IEnumerable<Animal> simpleIEnumerable,
        IEnumerable<ListType<Animal>> notSimpleIEnumerable)
    {
        if (simpleList.Count == 1 && simpleList.First() == 0)
        {
        }
        else if (simpleList.Count == 2 && simpleList.First() == 1)
        {
        }


        switch (simpleList)
        {
            case [1]:
                break;
            case [2, _]:
                break;
        }


        switch (notSimpleList)
        {
            // ReSharper disable once UnusedVariable
            case [.., ["", "another string", .. var rest], [null, MyConst]]:
                var s = rest is [.., MyConst];
                break;
        }

        switch (simpleArray)
        {
            case [1, 2, 3, .. var rest, 4]:
                Console.WriteLine(rest);
                break;
            case [1]:
                break;
            case [.. var rest]:
                Console.WriteLine(rest);
                break;
        }

        if (notSimpleArray.Length == 3 && notSimpleArray[1] is [.. var someVar, constInt2])
        {
        }

        if (notSimpleArray is [constArray])
        {
        }

        if (notSimpleArray.Length == 2 && (notSimpleArray[0] == constArray || notSimpleArray[0] == constArray2))
        {
        }

        //switch (simpleDictionary)
        //{
        //    case [..]:
        //        break;
        //}

        //if (notSimpleDictionary.Count == 1 && notSimpleDictionary[0] == null) {}

        //switch (notSimpleDictionary)
        //{
        //    case [null]:
        //        break;
        //}

        //switch (simpleIEnumerable)
        //{
        //    case [..]:
        //        break;
        //}

        switch (notSimpleIEnumerable.ToList())
        {
            case [[null], ..]:
                break;
            case [..]:
                break;

        }
    }

    public void Test2(int[] array)
    {
        if (array.Length == 3 && (array[0] == constInt1 || array[0] == constInt2))
        {
        }

        // ReSharper disable once MergeAndPattern
        if (array is not null and [> 12 or < 1, _, _])
        {
        }

        if (array is [>= 1] && array[0] >= constInt2)
        {
        }
    }
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

public class Animal
{
    public List<InnerAnimal> InnerAnimals { get; set; }
}

public class InnerAnimal
{
}