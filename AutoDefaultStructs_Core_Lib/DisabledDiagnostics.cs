namespace AutoDefaultStructs_Core_Lib;

public struct DisabledDiagnostics
{
    
}

public struct S1
{
    private object x;
}

// ConsoleApp1.csproj (references ClassLibrary1.csproj)
public struct S2
{   
    public S1 s1;

    public S2(bool unused) { }
}

public struct C
{
    public C()
    {
        // Is this warning expected?
        // CS9020: The 'this' object is read before all of its fields have been assigned, causing preceding implicit assignments of 'default' to non-explicitly assigned fields.
       // P = 5;
    }


}