namespace FileLocalTypes_CoreApp.Code;

file class Inheritance2
{
    public Inheritance2(string name)
    {
    }
}

file class Inheritance2Impl : Inheritance2
{
    public Inheritance2Impl(string name) : base(name)
    {
    }

    public void Test()
    {
        var inheritance2 = new Inheritance2("");
    }
}

public class UseInheritance2
{
    public void GetInheritance2()
    {
    }
}