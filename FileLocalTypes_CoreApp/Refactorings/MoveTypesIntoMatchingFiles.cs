namespace FileLocalTypes_CoreApp.Refactorings;

public class MoveTypesIntoMatchingFiles
{
    public void Test()
    {
        new DoNotMoveMe();
    }
}

file class DoNotMoveMe
{
}