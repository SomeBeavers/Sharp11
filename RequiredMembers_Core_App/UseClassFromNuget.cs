using RequiredMembers_NugetCore;

namespace RequiredMembers_Core_App;

public class UseClassFromNuget
{
    public void Test()
    {
        var classFromNuget = new ClassFromNuget
        {
            Name = "Jane Doe",
            ClassFromNuget2 = new ClassFromNuget2
            {
                Age = 0,
                Age2 = 0
            }
        };
    }
}