using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers_Core_App.Code;

public class Nullable
{
#nullable enable
    public class Base
    {
        public required string Prop1 { get; set; }

        public Base() {}

        [SetsRequiredMembers]
        public Base(int unused) { Prop1 = ""; }
    }
    public class Derived : Base
    {
        public required string Prop2 { get; set; }

        [SetsRequiredMembers]
        public Derived() : base()
        {
        } // Warning: Prop1 and Prop2 are possibly null.

        [SetsRequiredMembers]
        public Derived(int unused) : base()
        {
            Prop1.ToString(); // Warning: possibly null dereference
            Prop2.ToString(); // Warning: possibly null dereference
        }

        [SetsRequiredMembers]
        public Derived(int unused, int unused2) : this()
        {
            Prop1.ToString(); // Ok
            Prop2.ToString(); // Ok
        }

        [SetsRequiredMembers]
        public Derived(int unused1, int unused2, int unused3) : base(unused1)
        {
            Prop1.ToString(); // Ok
            Prop2.ToString(); // Warning: possibly null dereference
        }
    }
}