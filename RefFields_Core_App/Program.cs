S local = default;
var s = local.Value.ToString();


ref struct S 
{
    public ref int Value;

    public S()
    {
    }
}

