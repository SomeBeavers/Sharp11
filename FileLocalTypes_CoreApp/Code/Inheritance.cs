namespace file;

file abstract class Inheritance
{
    public abstract required string Name { get; set; }

    public abstract Inheritance GetInheritance(string name);
}

file class InheritanceImpl : Inheritance
{
    public override string Name { get; set; }

    public override Inheritance GetInheritance(string name)
    {
        return null;
    }
}