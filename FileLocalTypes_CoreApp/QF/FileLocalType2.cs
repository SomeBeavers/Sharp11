namespace FileLocalTypes_CoreApp.QF1;

file class FileLocalType1
{
    public static void Test()
    {
    }
}

public class PublicClass
{
    public static void Test()
    {
    }
}

internal class UseClasses
{
    private void Test()
    {
        var publicClass = new PublicClass();
        PublicClass.Test();
        PublicClass.Test();
        PublicClass.Test();
        PublicClass.Test();
        PublicClass.Test();
        var fileLocalType1 = new FileLocalType1();
        FileLocalType1.Test();
        FileLocalType1.Test();
        FileLocalType1.Test();
        FileLocalType1.Test();
        FileLocalType1.Test();
        FileLocalType1.Test();
    }
}

file class UseClasses2
{
    private void Test()
    {
        var publicClass = new PublicClass();
        var fileLocalType1 = new FileLocalType1();
    }
}