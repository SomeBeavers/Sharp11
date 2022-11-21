namespace ListPatterns_Core_App;

public class Class1
{
    public void Test(int[] array)
    {
        if (array is [1,2])
        {
           // var array = new int[] { 1, 2, 3, 4, 5 };
            var thirdItem = array[2];    // array[2]
            var lastItem = array[^1];    // array[new Index(1, fromEnd: true)]  
        }
    }
}