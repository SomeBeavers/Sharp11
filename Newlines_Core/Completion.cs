namespace Newlines_Core;

public class Completion
{
    public const string Name = "";
    const string Title = "Title";
    const string Description = "Description";
    const string Author = "Author";
    private const string Jane = "Jane";

    public string field=$"{new List<InnerClass>()
        .FirstOrDefault(item => item.BooleanProperty1)!
        .BooleanProperty1}";

    private void Test()
    {
    }
}

public class InnerClass
{
    public string Name { get; set; }
    public string Title { get; set; }

    public bool BooleanProperty1 { get; set; }

}