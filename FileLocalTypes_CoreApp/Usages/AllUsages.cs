namespace FileLocalTypes_CoreApp.Usages;

public class AllUsages
{
    public void Test()
    {
        AllUsagesFileClass fileClass = null;

        void LocalFunction(AllUsagesFileClass parameter)
        {
            fileClass = parameter.PublicMethod(parameter);
        }

        var privateInnerClasses = 
            new List<PrivateInnerClass>().Where(x => x.Property.PublicMethod().Equals(null));


        LocalFunction(fileClass);

        Console.WriteLine(fileClass);
    }
}

file partial class PrivateInnerClass
{
    public AllUsagesFileClass? Property { get; }

    public void Test(int parameter)
    {
        var allUsagesFileClass = new AllUsagesFileClass();

        allUsagesFileClass.PublicMethod(allUsagesFileClass);
    }
}

file partial class PrivateInnerClass
{
}

file class AllUsagesFileClass
{
    private AllUsagesFileClass PrivateMethod(AllUsagesFileClass parameter = null)
    {
        return null;
    }

    public AllUsagesFileClass PublicMethod(AllUsagesFileClass parameter = null)
    {
        return null;
    }
}