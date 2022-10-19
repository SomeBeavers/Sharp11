namespace file;

file static class ExtensionMethods
{
    public static int Extension1(this List<int> list)
    {
        return list.Count;
    }
}

public class A1
{
    public void Test(List<int> list)
    {
        var i = file.ExtensionMethods.Extension1(list);
        var extension1 = list.Extension1();
    }
}