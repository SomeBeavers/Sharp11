namespace utf8_Core_Lib;

public ref struct ClassFromReferencedProject
{
    public ReadOnlySpan<byte> field = null;
    public ReadOnlySpan<byte> field2 = "null"U8;

    public ClassFromReferencedProject()
    {
    }

    public ReadOnlySpan<byte> Test()
    {
        return ""u8;
    }
}