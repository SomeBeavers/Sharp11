// See https://aka.ms/new-console-template for more information

using CheckedOperators_Core_Lib;

Console.WriteLine("Hello, World!");

var typing = new Typing();

var typing1 = checked(typing + typing);
var typing2 = typing + typing;