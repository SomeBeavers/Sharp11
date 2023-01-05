namespace RefFields_Core_App;

file class UseScoped1
{
    public void Test(Struct1 s, ref int t, scoped ref Int128 t1)
    {
        LocalMethod(ref t1);
        void LocalMethod(scoped ref Int128 t){}
    }

    //Span<int> ScopedLocalExamples()
    //{
    //    // Error: `span` has a safe-to-escape of *current method*. That is true even though the 
    //    // initializer has a safe-to-escape of *calling method*. The annotation overrides the 
    //    // initializer
    //    scoped Span<int> span = default;
    //    return span;
    //}
}

file ref struct Struct1
{
    public ref int t;
}



