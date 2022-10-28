namespace utf8_Core_App.Code;

public class UserDefinedConversions
{
    class C
    {
        static void Main()
        {
            //var y = (C2)"dog"u8; // error CS0030: Cannot convert type 'byte[]' to 'C2'
            var z = (C3)"cat"; 
        }
    }

    class C2
    {
        public static implicit operator C2(Span<byte> x) => new C2();
    }

    class C3
    {
        //public static explicit operator C3(ReadOnlySpan<byte> x) => new C3();
        public static explicit operator C3(string x) => new C3();
    }
}