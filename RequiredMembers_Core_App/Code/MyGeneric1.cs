using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

public class MyGeneric1<T, U> where T : struct where U : class
{
    public required Dictionary<T, U> Dictionary { get; set; }

    public void Test()
    {
        //var u = new U();
    }
}

public class UseMyGeneric1
{
    public void Test()
    {
        var myGeneric1 = new MyGeneric1<int, ClassWithRequiredProperties>
        {
            Dictionary =new Dictionary<int, ClassWithRequiredProperties>()
            {
                //{1, new ClassWithRequiredProperties()},
                [2]= new ClassWithRequiredProperties
                {
                    Name = null
                }
            }
        };
        var myGeneric2 = new MyGeneric1<int, ClassWithRequiredProperties>
        {
            Dictionary =new Dictionary<int, ClassWithRequiredProperties>()
            {
                {1, new ClassWithRequiredProperties
                    {
                        Name = null
                    }
                },
                //[2]= new ClassWithRequiredProperties()
            }
        };
        var dictionary = new Dictionary<int, ClassWithRequiredProperties>();
        dictionary.Add(1,
            new ClassWithRequiredProperties
            {
                Name = "null"
            });
    }
}

public class ClassWithRequiredProperties
{
    //[SetsRequiredMembers]
    public ClassWithRequiredProperties()
    {
    }

    [SetsRequiredMembers]
    public ClassWithRequiredProperties(string name)
    {
        Name = name;
    }

    public required string Name { get; set; } = null!;
}