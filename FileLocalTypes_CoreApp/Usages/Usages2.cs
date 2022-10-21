namespace FileLocalTypes_CoreApp.Usages;

public class Usages2
{
    
}

file class Widget
{
}

public class Program2
{
    //private void M1(Widget w) { } // ok
    //internal void M2(Widget w) { } // error
}

partial class Utils
{
    //private void M1(Widget w) { } // error
}