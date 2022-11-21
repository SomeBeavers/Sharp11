namespace ListPatterns_Core_App.Code;

public class Indexer
{
    public void Test(UserDefinedCollection<UserDefinedType?> collection)
    {
        var myLocal = new UserDefinedType();
        switch (collection)
        {
            case [{ Name: "" }, .. var rest]:
                Console.WriteLine(rest);
                Console.WriteLine(myLocal);
                break;
            case [{ Name: "not empty" }, .. var rest]:
                Console.WriteLine(rest);
                Console.WriteLine(myLocal);
                break;
            case [null, var first, var second, var third]:
                Console.WriteLine("""
    {0} {1} {2}
    """,
                    first,
                    second,
                    third);
                break;
        }
    }

    public class UserDefinedCollection<T>
    {
        private T[] arr;
        //public int Length { get; set; }

        public int Count { get; set; }
        //public int Length;

        public T this[Index i, int test = 0]
        {
            get => arr[i];
            set => arr[i] = value;
        }

        //public T[] this[int start, int end, int ignored = 0]
        //{
        //    get => arr;
        //}

        //public T this[int i]
        //{
        //    get => arr[i];
        //    set => arr[i] = value;
        //}

        public T[] this[Range i, int test = 0] => arr[i];

        //public T[] Slice(int start, int length)
        //{
        //    var slice = new T[length];
        //    Array.Copy(arr,
        //        start,
        //        slice,
        //        0,
        //        length);
        //    return slice;
        //}
    }
}

public class UserDefinedType
{
    public string Name { get; set; }
}