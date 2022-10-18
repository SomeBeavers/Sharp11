namespace file;
#nullable disable

public abstract class Inheritance
{
    public abstract required string Name { get; set; }

    public abstract Inheritance GetInheritance(string name);
}

file class InheritanceImpl : Inheritance
{
    public override required string Name { get; set; }

    public override Inheritance GetInheritance(string name)
    {
        return null;
    }

    public MyEnum GetEnum(MyEnum parameter = MyEnum.A)
    {
        return parameter;
    }
}

file enum MyEnum
{
    A, B, C
}