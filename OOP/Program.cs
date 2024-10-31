// See https://aka.ms/new-console-template for more information

using OOP.Constructions;

Console.WriteLine("Hello, World!");
//var construction1 = new Construction();
var construction2 = new Construction(23.0f, 45.0f, 4, 4, "Material");
Console.WriteLine("Hello, World!");
try
{
    var construction3 = new Construction(11, 10, 2, 2, null);
}
catch (ArgumentException e)
{
    Console.Error.WriteLine(e);
}
