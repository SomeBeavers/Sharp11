namespace FileLocalTypes_CoreApp.Code;

public class AllTypes
{
}

file class FileClass
{
}

file record FileRecord(string Name)
{
    private FileEnum fileEnum;

    public FileEnum Test(string Name)
    {
        fileEnum = FileEnum.a;
        return fileEnum;
    }
}

file record struct FileRecordStruct
{
}

file struct FileStruct
{
    public FileRecordStruct field;
}

file enum FileEnum
{
    a,
    b,
    c
}

file interface IFileInterface
{
    public string Name { get; set; }
    public IFileInterface Method1();

    public IFileInterface Method2()
    {
        return null;
    }
}

file class FileInterface : IFileInterface
{
    public void Test()
    {
    }

    public string Name { get; set; }
    public IFileInterface Method1()
    {
        return null;
    }
}

file delegate int PerformCalculation(int x, int y);