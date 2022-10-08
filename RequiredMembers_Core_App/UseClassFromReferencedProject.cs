using RequiredMembers_Net6_Sharp11_ReferenceMe;

namespace RequiredMembers_Core_App;

public class UseClassFromReferencedProject
{
    public void Test()
    {
        var classFromReferencedProject = new ClassFromReferencedProject
        {
            Name = null
        };
    }
}