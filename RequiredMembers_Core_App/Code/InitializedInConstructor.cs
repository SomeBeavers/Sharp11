using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

public class InitializedInConstructor<T>
{
    public required T requiredField;


    [SetsRequiredMembers]
    public InitializedInConstructor():this("")
    {
    }


    [SetsRequiredMembers]
    public InitializedInConstructor(T requiredField):this("")
    {
        this.requiredField = requiredField;
    }

    [SetsRequiredMembers()]
    private InitializedInConstructor(string empty)
    {
    }

    public required InitializedInConstructor2 RequiredProperty1 { get; set; }
}

public class InitializedInConstructor2
{
    public required List<int> FieldCollection = new();
    public required InitializedInConstructor2 RequiredProperty2 { get; set; }
    public required string Name { get; set; }
}

public class UseInitializedInConstructor<T>
{
    public void Test()
    {
        var initializedInConstructor = 
            new InitializedInConstructor<UseInitializedInConstructor<string>>(null);
    }
}