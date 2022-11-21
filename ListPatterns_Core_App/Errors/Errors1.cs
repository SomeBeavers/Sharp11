namespace ListPatterns_Core_App.Errors;

public class Errors1
{
    private const int[][] x = null;
    private const int[] x2 = null;

    private const int p = 1;

    public void Test(int[][] multiArray)
    {
        if (multiArray is [.., [1,2, .., 10], x2])
        {
        }
        else if (multiArray.First() is x2)
        {
            
        }
    }

    public void Test2(int[] array)
    {
        switch (array)
        {
            case [1, 1]:
                break;
            case [p, .., 1]:
                break;
        }
    }
}