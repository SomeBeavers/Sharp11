//namespace RequiredMembers_Core_App.Code;

//interface I
//{
//    int Prop1 { get; }
//}
//public class Base
//{
//    public virtual int Prop2 { get; set; }

//    protected required int _field; // Error: _field is not at least as visible as Base. Open question below about the protected constructor scenario

//    public required readonly int _field2; // Error: required fields cannot be readonly
//    protected Base() { }

//    protected class Inner
//    {
//        protected required int PropInner { get; set; } // Error: PropInner cannot be set inside Base or Derived
//    }
//}
//public class Derived : Base, I
//{
//    required int I.Prop1 { get; } // Error: explicit interface implementions cannot be required as they cannot be set in an object initializer

//    public required override int Prop2 { get; set; } // Error: this property is hidden by Derived.Prop2 and cannot be set in an object initializer
//    public new int Prop2 { get; }

//    public required int Prop3 { get; } // Error: Required member must have a setter or initer

//    public required int Prop4 { get; internal set; } // Error: Required member setter must be at least as visible as the constructor of Derived
//}