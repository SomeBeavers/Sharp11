using utf8_Core_Lib;

namespace utf8_Core_App;

public ref struct UseReferencedProject
{

    public ReadOnlySpan<byte> Name;

    public void Test()
    {
        var referencedProject = new ClassFromReferencedProject();

        var readOnlySpan = referencedProject.Test();
        readOnlySpan = Name;
        if (readOnlySpan == ""u8)
        {
            Console.WriteLine(referencedProject.field.ToString());
        }
    }
}