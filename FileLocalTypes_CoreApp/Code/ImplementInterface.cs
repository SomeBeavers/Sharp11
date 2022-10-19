namespace FileLocalTypes_CoreApp.Code;

file interface IImplementInterface
{
    ImplementInterface Test();
}

file partial class ImplementInterface2 : IImplementInterface
{
    public ImplementInterface Test()
    {
        return null;
    }
}

file partial class ImplementInterface : IImplementInterface
{
    public ImplementInterface Test()
    {
        return null;
    }
}