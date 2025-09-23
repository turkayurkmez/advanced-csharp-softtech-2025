// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");
int x = 5;
Console.WriteLine(x.GetSquare());

Console.WriteLine(7.GetSquare());
Console.WriteLine(new Random().NextLetter());
Console.WriteLine(new Random().NextPassword(8));

