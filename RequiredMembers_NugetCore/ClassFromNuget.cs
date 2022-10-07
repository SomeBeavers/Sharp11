namespace RequiredMembers_NugetCore;

public class ClassFromNuget
{
    public ClassFromNuget()
    {
    }

    public ClassFromNuget(string name, ClassFromNuget2 classFromNuget2)
    {
        Name = name;
        ClassFromNuget2 = classFromNuget2;
    }

    public required string Name { get; set; }
    public required ClassFromNuget2 ClassFromNuget2 { get; set; }

}

public class ClassFromNuget2
{
    public required int Age { get; set; }
    public required int Age2 { get; set; }

}