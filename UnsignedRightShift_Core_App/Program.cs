// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var i = 11>>> 2;
const int i2 = 11>>>2;
const int i3 = 11>>> 2;
i>>>= i2;

var i1 = (int)((uint)i >> i2);

var myNint = nint.MinValue;

myNint>>>= 1;
myNint>>>= 12;

Console.WriteLine(myNint);


Console.WriteLine(i);