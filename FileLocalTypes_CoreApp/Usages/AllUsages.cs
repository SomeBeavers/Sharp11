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
            new List<PrivateInnerClass1>().Where(x => x.Property.PublicMethod().Equals(null));


        LocalFunction(fileClass);

        Console.WriteLine(fileClass);
    }
}

file partial class PrivateInnerClass1
{
    public AllUsagesFileClass? Property { get; }

    public void Test(int parameter)
    {
        var allUsagesFileClass = new AllUsagesFileClass();

        allUsagesFileClass.PublicMethod(allUsagesFileClass);
    }
}

file partial  class PrivateInnerClass1
{
    public PrivateInnerClass1()
    {
    }
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