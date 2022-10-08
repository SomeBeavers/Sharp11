using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

public class RequiredField<T> where T : class
{
    public const string S = "";
    public required T? requiredField;
    public int t;
    public required int t2;

    public required T[] arr = new T[100];

    public T this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }

    // Declare the delegate (if using non-generic pattern).
    public delegate void SampleEventHandler(object sender, SampleEventArgs e);

    // Declare the event.
    public event SampleEventHandler SampleEvent;

    // Wrap the event in a protected virtual method
    // to enable derived classes to raise the event.
    protected virtual void RaiseSampleEvent()
    {
        // Raise the event in a thread-safe manner using the ?. operator.
        SampleEvent?.Invoke(this, new SampleEventArgs("Hello"));
    }
}

public class SampleEventArgs
{
    public required string UriHostNameType { get; set; }

    [SetsRequiredMembers]
    public SampleEventArgs(string hello)
    {
    }
}

public class UseRequiredField
{
    public void Test()
    {
        var requiredField = new RequiredField<InnerClass>/*caret*/
        {
            // requiredField = null,
            t = 0,
            requiredField = null,
            t2 = 0,
            arr = new InnerClass[]
            {
                new InnerClass
                {
                    Name = "Jane Doe"
                },
                new InnerClass
                {
                    Name = null
                }
            }
        };

        requiredField[0] = new InnerClass
        {
            Name = null
        };
    }



    public class InnerClass
    {
        public required string? Name;
        public InnerClass()
        {
            var useRequiredField = new RequiredField<UseRequiredField>
            {
                requiredField = null,
                t = 0,
                t2 = 0,
#pragma warning disable CA1825
                arr = new UseRequiredField[]
#pragma warning restore CA1825
                {
                }
            };
        }
    }
}

public class GenericClass<T>
{
    public required T[] List { get; set; }
}

public class AnotherClass
{
    public required string Name { get; set; }
}

public class UseGenericClass<T> where T : new()
{
    public void Test()
    {
        var genericClass = new GenericClass<T>
        {
            List = new T[]
            {
                new T()
            }
        };
        AnotherClass anotherClass;
        anotherClass = new AnotherClass
        {
            Name = null
        };
    }

    public class InnerClassNew
    {
        public required string Name;
    }
}