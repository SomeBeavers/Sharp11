using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

public class Usage<T>
{
    public required InnerUsage<T> RequiredField;

    public Usage()
    {
    }

    public required string? Name { get; set; }
    public required T[,] Values { get; set; }

    public required int Age { get; set; }

    public class InnerUsage<U>
    {
        public required U RequiredProperty { get; set; }
    }
}

public class UseUsage<T>
{
    public void Test<U>() where U : new()
    {
        //var usage = new Usage<U>
        //{
        //    Name = null,
        //    Values = new U[,]
        //    {
        //    }
        //};
        //usage.RequiredField.RequiredProperty = new();

        var usage = new Usage<U>
        {
            Name = null,
            Values = new U[,]
            {
            },
            RequiredField =new Usage<U>.InnerUsage<U>
            {
                RequiredProperty = new U()
            },
            Age = 0
        };
    }
}