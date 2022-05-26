namespace AutoDefaultStructs_Core_Lib;

public struct RefactoringsStruct1
{
    public MyAge Age1;
    private MyAge? myField;

    public RefactoringsStruct1(int age)
    {
        if (Age1 != myField) Age1!.RealAge = age;
    }
}

public class MyAge
{
    public int RealAge;
    int t;
}

public class UseRefactoringsStruct
{
    private int age;

    private void Test()
    {
        var refactoringsStruct = new RefactoringsStruct1(age);
        var refactoringsStructAge = refactoringsStruct.Age1;
    }
}