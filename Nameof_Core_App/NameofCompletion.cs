namespace Nameof_Core_App;

public class NameofCompletion
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="parameter">test</param>
    [My(nameof(parameter))]
    public void Test(string parameter)
    {
    }
}