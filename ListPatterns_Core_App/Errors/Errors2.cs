using System.Linq;
using System.Linq.Expressions;

namespace ListPatterns_Core_App.Errors;

public class Errors2
{
    public void Test1(MyCollection1<InnerType> collection, MyCollection1<int> collection2, dynamic dynamicParameter)
    {
        switch (collection)
        {
            case [.., { Name: "" }]:
                break;
        }

        var myVar = new List<List<int>>().Where(static x => x is
        [
            1,
            2,
            3, 
            .. /*int s1*/,
            4
        ]);

        //var b2 = collection2[0] is [];
        //var b = collection[0] is [];
        //var b3 = dynamicParameter is [];
    }

    public class MyCollection1<T>
    {
        private readonly T[] arr = new T[100];
        public int Count { get; set; }
        public string Name { get; set; }

        public T this[int i]
        {
            internal get => arr[i];
            set => arr[i] = value;
        }
    }
}

public class InnerType
{
    public string Name { get; set; }
    public int Count { get; set; }

}