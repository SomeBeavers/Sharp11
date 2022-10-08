namespace RequiredMembers_Core_App.Code;

public interface IMyInterface2<out T>
{
    public T[] Name { get; }
}

internal class MyInterface2<T> : IMyInterface2<T>
{
    private T?[]? value;
    public required T[] Name { get; internal set; }

    public required T?[]? Value
    {
        get => value;
        set => this.value = value;
    }
}

internal class UseMyInterface2<U>
{
    public UseMyInterface2(MyInterface2<U> interface2)
    {
        IMyInterface2<U> a = new MyInterface2<U>
        {
            Value = new U?[]
            {
            },
            Name = new U[]
            {
            }
        };
    }
}