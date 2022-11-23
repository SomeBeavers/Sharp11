namespace ListPatterns_Core_App.Code;

public readonly struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        (X, Y) = (x, y);
    }

    public void Deconstruct(out int x, out int y)
    {
        (x, y) = (X, Y);
    }
}

public class Indexer
{
    private const int age = 1;

    private static string PrintIfAllCoordinatesArePositive(object point)
    {
        return point switch
        {
            Point2D (> 0, > 0) p => p.ToString(),
            Point3D (> 0, > 0, > 0) p => p.ToString(),
            _ => string.Empty
        };
    }

    public void Test3(object?[]? collection)
    {
        switch (collection)
        {
            case [Point2D (> 0, > 0) point1, Point3D (0, 0, 0) point3D, _]:
                break;
        }


        List<int> numbers = new() { 1, 2, 3 };

        if (numbers is [var first, _, _]) Console.WriteLine($"The first element of a three-item list is {first}.");

        Console.WriteLine(new[] { 1, 2, 3, 4, 5 } is [> 0, > 0, ..]); // True
        Console.WriteLine(new[] { 1, 1 } is [_, _, ..]); // True
        Console.WriteLine(new[] { 0, 1, 2, 3, 4 } is [> 0, > 0, ..]); // False
        Console.WriteLine(new[] { 1 } is [1, 2, ..]); // False

        Console.WriteLine(new[] { 1, 2, 3, 4 } is [.., > 0, > 0]); // True
        Console.WriteLine(new[] { 2, 4 } is [.., > 0, 2, 4]); // False
        Console.WriteLine(new[] { 2, 4 } is [.., 2, 4]); // True

        Console.WriteLine(new[] { 1, 2, 3, 4 } is [>= 0, .., 2 or 4]); // True
        Console.WriteLine(new[] { 1, 0, 0, 1 } is [1, 0, .., 0, 1]); // True
        Console.WriteLine(new[] { 1, 0, 1 } is [1, 0, .., 0, 1]); // False
// Output:
// The first element of a three-item list is 1.

        void MatchMessage(string message)
        {
            var result = message is ['a' or 'A', .. var s, 'a' or 'A']
                ? $"Message {message} matches; inner part is {s}."
                : $"Message {message} doesn't match.";
            Console.WriteLine(result);
        }

        MatchMessage("aBBA"); // output: Message aBBA matches; inner part is BB.
        MatchMessage("apron"); // output: Message apron doesn't match.

        void Validate(int[] numbers)
        {
            var result = numbers is [< 0, .. { Length: 2 or 4 }, > 0] ? "valid" : "not valid";
            Console.WriteLine(result);
        }

        Validate(new[] { -1, 0, 1 }); // output: not valid
        Validate(new[] { -1, 0, 0, 1 }); // output: valid
    }

    private static string Classify(Point point)
    {
        return point switch
        {
            (0, 0) => "Origin",
            (1, 0) => "positive X basis end",
            (0, 1) => "positive Y basis end",
            _ => "Just a point"
        };
    }

    public string? Test2(Point[] points)
    {
        return points switch
        {
            [(<= 1, 2), .. [(>= 0, 0), { X: > 1, Y: 2 }, ..] slice1, (1, 1)] => "test",
            not [(1, 2)] => "test2",
            _ => null
        };
    }

    public void Test(UserDefinedCollection<UserDefinedType?> collection, List<int> list)
    {
        var myLocal = new UserDefinedType();
        const string janeDoe = "Jane Doe";

        switch (collection)
        {
            case { Count: > 1 } and
            [
                { Name: "someCoolName", InnerType: not null } or { Name: "someNotCoolName" }, { Age: 12 }, .. var rest,
                { Name: janeDoe, Age: age } rest2
            ]:
                break;

            case [{ Name: "" }, .. var rest]:
                Console.WriteLine(rest);
                Console.WriteLine(myLocal);
                break;
            case [{ Name: "not empty" }, .. var rest]:
                Console.WriteLine(rest);
                Console.WriteLine(myLocal);
                break;
            case [not null, var first, var second, var third]:
                Console.WriteLine("""
    {0} {1} {2}
    """,
                    first,
                    second,
                    third);
                break;
        }

        if (collection is [{ } userDefinedType] and { } test)
        {
        }

        //UserDefinedCollection<UserDefinedType?> localVar = null;
        if (collection.Count == 2 && collection[0] is { } localVar) Console.WriteLine(localVar);


        switch (list)
        {
            case [_, 1, ..]:
                // expr.Length is >= 2 && expr[1] is 1
                break;
            case [.., 1, _]: // expr.Length is >= 2 && expr[^2] is 1
                break;
            case [_, > 2 or <= 0, ..] or [.., <= 0, _]:
                break;
            //case .. []:
            case [..] or [.., 1, _]:
                break;
        }
    }

    public record Point2D(int X, int Y);

    public record Point3D(int X, int Y, int Z);

    public class UserDefinedCollection<T>
    {
        private T[] arr;
        //public int Length { get; set; }

        public int Count { get; set; }
        //public int Length;

        public T this[Index i]
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

        //public T[] this[Range i, int test = 0] => arr[i];
        //public T[] this[long p]=> null;

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
}

public class UserDefinedType
{
    public string Name { get; set; }
    public int Age { get; set; }
    public InnerType InnerType { get; set; }
}

public class InnerType
{
    public string? InnerTypeName { get; set; }
}