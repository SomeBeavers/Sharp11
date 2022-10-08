namespace RequiredMembers_Core_App;

public interface IRequired_Refactorings
{
    public string Name { get; set; }
}

public class Required_Refactorings : IRequired_Refactorings
{
    public required string Name { get; set; }
}