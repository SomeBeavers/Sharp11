namespace Nameof_Core_App;

public class AttributeOn
{
    [My(nameof(x))]
    public delegate int MyDelegate(int x, int y);

    [My(nameof(corParameter))]
    public AttributeOn(string corParameter)
    {
    }

    [My(nameof(a))]
    public static AttributeOn operator +(AttributeOn a)
    {
        return null;
    }


    private void Test(string s)
    {
        var myVar =  
            ([My(nameof(s))]string s) => "" + s;

        [My(nameof(localFunctionParameter))]
        void LocalFunction(string localFunctionParameter
        ,
        List<InnerClass> list)
        {
            list.Where([My(nameof(s))](x) 
                => x.Age == 1);
        }
    }
}

internal class InnerClass
{
    public string Name { get; set; }
    public int Age { get; set; }
}