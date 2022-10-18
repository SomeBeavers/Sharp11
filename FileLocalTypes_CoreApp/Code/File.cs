namespace FileLocalTypes_CoreApp.Code;

file class @file<T> where T: FileClass, new()
{
    public void Test()
    {
        T t = new T();
        //var @int = 1;
    }
}

file class FileClass
{

}


public class UseFileClass
{
    public void Test()
    {
        var file = new file<FileClass>();
    }
}