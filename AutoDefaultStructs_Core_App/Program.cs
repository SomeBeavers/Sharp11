// See https://aka.ms/new-console-template for more information

using AutoDefaultStructs_Core_Lib;
using AutoDefaultStructs_Core_Lib.Playground;
using AutoDefaultStructs_Nuget;

Console.WriteLine("Hello, World!");

new StructCor(new MyProp());
new StructFromNuget();

// Play

var play1 = new Play1_renamed(null)
{
    Field1 = new StructCor()
};